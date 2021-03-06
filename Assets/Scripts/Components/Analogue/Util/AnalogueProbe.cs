﻿using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Components;
using Assets.Scripts.Simulation.Components.Wires;
using Assets.Scripts.Simulation.State;
using UnityEngine;

internal class AnalogueProbe : Chip
{
    private readonly AnalogueWire instrumentedAnalogueWire;
    private readonly string probeName;
    private readonly Ship ship;

    public AnalogueProbe(Brain brain, Ship ship, World world, string probeName, AnalogueWire instrumentedAnalogueWire) : base()
    {
        this.ship = ship;
        this.instrumentedAnalogueWire = instrumentedAnalogueWire;
        this.probeName = probeName;
    }

    public override void OnClockEdge()
    {
        Debug.Log(probeName + "Ship Id: " + ship.ShipId + " probe value: " + instrumentedAnalogueWire.SignalValue);
    }
}
