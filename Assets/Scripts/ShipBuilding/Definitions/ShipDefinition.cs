﻿using System.Collections.Generic;
using Assets.Scripts.ShipBuilding.Definitions;

namespace Assets.Scripts.ShipLoader.ShipLoading
{
    public enum ShipViewType
    {
        BasicShip
    }

    public class ShipDefinition
    {
        public ShipViewType ShipViewType;
        public List<HardpointDefinition> HardpointDefinitions;
        public List<ComponentDefinition> ComponentDefinitions;
        public List<WireDefinition> WireDefinitions;

        //For Testing
        public ShipDefinition(ShipViewType shipViewType, List<HardpointDefinition> hardpointDefinitions, List<ComponentDefinition> componentDefinitions, List<WireDefinition> wireDefinitions)
        {
            ShipViewType = shipViewType;
            HardpointDefinitions = hardpointDefinitions;
            ComponentDefinitions = componentDefinitions;
            WireDefinitions = wireDefinitions;
        }
    }
}
