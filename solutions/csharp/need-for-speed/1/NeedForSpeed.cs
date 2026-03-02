class RemoteControlCar
{
    private int _speed;
    private int _drain;
    private int _battery = 100;
    private int _distanceDriven = 0;

    public RemoteControlCar(int s, int d) { this._speed = s; this._drain = d; } 
    public bool BatteryDrained() => _battery < _drain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (_battery >= _drain)
        {
            _distanceDriven += _speed;
            _battery -= _drain;
        }
    }

    public int remainingMilage() => (_battery / _drain) * _speed;

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _milage;
    public RaceTrack(int m) => this._milage = m;

    public bool TryFinishTrack(RemoteControlCar car) =>  (_milage <= car.remainingMilage());
}
