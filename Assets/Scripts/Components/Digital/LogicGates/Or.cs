﻿using Assets.Scripts.Simulation.Components;
using Assets.Scripts.Simulation.Components.Wires;
using Assets.Scripts.Simulation.State;

internal class Or : Chip
{
    private readonly DigitalWire aInput;
    private readonly DigitalWire bInput;
    private readonly DigitalWire resultOutput;

    public Or(Ship ship, DigitalWire aInput, DigitalWire bInput, DigitalWire resultOutput)
    {
        this.resultOutput = resultOutput;
        this.bInput = bInput;
        this.aInput = aInput;
    }

    public override void OnClockEdge()
    {
        resultOutput.SignalValue = aInput.SignalValue || bInput.SignalValue;
    }
}