﻿using Assets.Scripts.Simulation.Components;
using Assets.Scripts.Simulation.Components.Wires;
using Assets.Scripts.Simulation.State;
using UnityEngine;

internal class DigitalProbe : Chip
{
    private readonly DigitalWire instrumentedDigitalWire;
    private readonly string probeName;
    private readonly Ship ship;

    public DigitalProbe(Ship ship, string probeName, DigitalWire instrumentedDigitalWire)
    {
        this.ship = ship;
        this.instrumentedDigitalWire = instrumentedDigitalWire;
        this.probeName = probeName;
    }

    public override void OnClockEdge()
    {
        Debug.Log(probeName + "Ship Id: " + ship.ShipId + " probe value: " + instrumentedDigitalWire.SignalValue);
    }
}