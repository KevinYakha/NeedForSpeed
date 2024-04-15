using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
    }

    public int DistanceDriven()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
    }

    public void Drive()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }

    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }

    private int _speed;
    private int _batteryDrain;
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }

    private int _distance;
}
