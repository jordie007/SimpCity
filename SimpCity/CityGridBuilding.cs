﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpCity {
    /// <summary>
    /// Represents a building in the grid.
    /// </summary>
    public abstract class CityGridBuilding {
        public CityGrid Grid { get; protected set; }
        public BuildingInfo Info { get; protected set; }

        public CityGridBuilding(BuildingInfo info) {
            Info = info;
            Grid = info.Grid;
        }

        /// <summary>
        /// Adds the building into the specified grid  position.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">When the building already has a spot in the grid</exception>
        /// <exception cref="System.IndexOutOfRangeException">When the position is out of bounds</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">When the position is already occupied</exception>
        public void Add(CityGridPosition pos) {
            Grid.Add(this, pos);
        }

        /// <summary>
        /// Retrives  current position of the building in the grid.
        /// </summary>
        public CityGridPosition Position() {
            return Grid.PositionOf(this);
        }

        /// <summary>
        /// Calculate the score to award in the current state.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">When the building does not have a spot in the grid</exception>
        public int CalcScore() {
            // TODO: Sprint 2's score calculation
            throw new NotImplementedException("CalcScore");
        }
    }
}
