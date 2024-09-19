namespace Event_practice5
{
    public class Zoo
    {
        public int AnimalCount { get; private set; }
        public delegate void ZooEventHandler(object sender, AnimalCountChangedEventArgs e);
        public event ZooEventHandler? AnimalAdded;
        public event ZooEventHandler? AnimalRemoved;

        public void AddAnimal()
        {
            int oldCount = AnimalCount;
            AnimalCount++;
            OnAnimalAdded(new AnimalCountChangedEventArgs(oldCount, AnimalCount));

        }
        public void RemoveAnimal()
        {
            int oldCount = AnimalCount;
            if (AnimalCount > 0) {
                AnimalCount--;
                OnAnimalRemoved(new AnimalCountChangedEventArgs(oldCount, AnimalCount));
            }

        }
        public void OnAnimalAdded(AnimalCountChangedEventArgs e)
        {
            AnimalAdded?.Invoke(this, e);
        }
        protected virtual void OnAnimalRemoved(AnimalCountChangedEventArgs e)
        {
            AnimalRemoved?.Invoke(this, e);
        }

    }

    public class AnimalCountChangedEventArgs : EventArgs
    {
        public double OldCount { get; private set; }
        public double NewCount { get; private set; }
        public AnimalCountChangedEventArgs(int oldCount, int newCount)
        {
            OldCount = oldCount;
            NewCount = newCount;
        }
    }
}
