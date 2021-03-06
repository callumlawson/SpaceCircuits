﻿using Assets.Scripts.Simulation.Components;
using Assets.Scripts.Simulation.Components.Wires;
using Assets.Scripts.Simulation.State;

internal class DigitalBuffer : Chip
{
    private readonly DigitalWire bufferInput;
    private readonly DigitalWire bufferOutput;

    public DigitalBuffer(Ship ship, DigitalWire bufferInput, DigitalWire bufferOutput)
    {
        this.bufferOutput = bufferOutput;
        this.bufferInput = bufferInput;
    }

    public override void OnClockEdge()
    {
        bufferOutput.SignalValue = bufferInput.SignalValue;
    }
}