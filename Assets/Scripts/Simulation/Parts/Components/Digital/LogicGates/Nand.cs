﻿internal class Nand : Component
{
    private readonly DigitalWire aInput;
    private readonly DigitalWire bInput;
    private readonly DigitalWire resultOutput;

    public Nand(EngineEvents engineEvents, Simulation simulation, Ship ship, World world, DigitalWire aInput, DigitalWire bInput, DigitalWire resultOutput)
        : base(engineEvents, simulation, ship, world)
    {
        this.resultOutput = resultOutput;
        this.bInput = bInput;
        this.aInput = aInput;
    }

    public override void OnClockEdge()
    {
        resultOutput.SignalValue = !(aInput.SignalValue && bInput.SignalValue);
    }
}