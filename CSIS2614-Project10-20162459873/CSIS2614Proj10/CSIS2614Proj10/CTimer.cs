//2016245983
//Nxele Siphenathi
//CSIS2614 Project 10
//Due date: 06 May 2019
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

//http://www.codeproject.com/Articles/2635/High-Performance-Timer-in-C
public delegate void delOnTick(double msElapsed);

public class CTimer
{
    //Event
    public event delOnTick OnTick;

    //API interface
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceFrequency(out long lpFrequency);

    //Private data members
    private long startTime, stopTime;
    private long freq;
    public bool isRunning { get; private set; }
    private uint interval;
    public uint Interval
    {
        get { return interval; }
        set
        {
            if (value > 0)
            {
                bool wasRunning = isRunning;
                Stop();
                interval = value;
                startTime = stopTime = 0;

                if (wasRunning)
                    Start();

            }            
        }
    }
    private System.Threading.Timer thrTimer;
    private long lastTick;

    // Constructor
    public CTimer(uint _interval)
    {
        startTime = 0;
        stopTime = 0;
        isRunning = false;
        Interval = _interval;

        //Get frequency
        if (QueryPerformanceFrequency(out freq) == false)
            // High-performance counter not supported
            throw new Win32Exception();
    } //Constructor

    // Start the timer
    public void Start()
    {
        //Create timer to poll duration every 1 ms
        TimerCallback cbTimer = this.Tick;
        thrTimer = new System.Threading.Timer(cbTimer, null, 0, 1); //Interval small enough so that it fits into any possible frame capturing interval
        lastTick = 0;

        isRunning = true;
        QueryPerformanceCounter(out startTime);
    } //Start

    // Stop the timer
    public void Stop()
    {
        if (isRunning)
        {
            isRunning = false;
            thrTimer.Dispose();
            QueryPerformanceCounter(out stopTime);
        }
    } //Stop

    // Returns the duration of the timer (in seconds)
    public double msDuration
    {
        get
        {
            if (isRunning)
            {
                long currentTime;
                QueryPerformanceCounter(out currentTime);
                return 1000 * (double)(currentTime - startTime) / (double)freq;
            }
            else
                return 1000 * (double)(stopTime - startTime) / (double)freq;
        }
    }//Duration

    //Tick for thread timer 
    //- executes every 1 ms and check if the previous interval has elapsed
    private void Tick(Object stateInfo)
    {
        try
        {
            //System.Windows.Forms.Application.DoEvents(); Kan hy wees!!
            long ms = (long)(msDuration + 0.5);
            long ticks = ms / interval; //Integer division - throw away remainder
            if (ticks > lastTick)
            {
                lastTick = ticks;
                if (OnTick != null && isRunning)
                    OnTick(msDuration);
            }
        }
        catch (Exception ex)
        {
            // Msg.ShowError("CTimer//Tick: " + ex.Message);
            //Stop();
        }
    } //Tick

} //class CTimer


