﻿using System;
using UnityEngine;
using XNode;

namespace TheBitCave.MMToolsExtensions.AI.Graph
{
    public interface IBrainGraph
    {
        AIStartSelectableNode StartingNode { get; set; }
        
        bool IsNodeCollapseModeOn { get; }

        void EnableNodeCollapse();

        void DisableNodeCollapse();
    }
}