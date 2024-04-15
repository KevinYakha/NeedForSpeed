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
        return !(_batteryPercentage >= _batteryDrain);
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += _speed;
            _batteryPercentage -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    private int _speed = 0;
    private int _batteryDrain = 0;
    private int _batteryPercentage = 100;
    private int _distanceDriven = 0;
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
        while(car.DistanceDriven() < _distance && !car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= _distance;
    }

    private int _distance;
}
