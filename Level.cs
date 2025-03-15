namespace BackToBasicsC_
{
    internal class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // returns true if the player wins and false if the player loses
        public bool Play()
        {
            //run until all invaders are neutralized or reach the end of the path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //each tower has an opportunity to fire on the invaders
                foreach (Tower tower in Towers)
                {
                    tower.ShootOnInvaders(_invaders);

                }
                //count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}
