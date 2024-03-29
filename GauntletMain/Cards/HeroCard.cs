﻿using System.Drawing;

namespace TrialOfFortune.Cards
{
    public class HeroCard : PlayerCard
    {
        public HeroCard(string name, Image artImage, Image miniArtImage, int healthPoints, int actionPoints, EntityStats stats)
            : base(name, artImage, miniArtImage, stats)
        {
            this.HealthPoints = healthPoints;
            this.ActionPoints = actionPoints;
        }

        public int HealthPoints { get; private set; }

        public int ActionPoints { get; private set; }

    }
}
