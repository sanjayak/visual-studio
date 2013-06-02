using System;
using System.Collections;

namespace MyCollections
{
    public delegate void ChangedEventHandler( object sender, EventArgs e );

    public class ListWithChangedEvent : ArrayList
    {
        public event ChangedEventHandler Changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
            }
        }

        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}


namespace TestEvents
{
    using MyCollections;

    class EventListner
    {
        private ListWithChangedEvent List;

        public EventListner(ListWithChangedEvent list)
        {
            List = list;
            List.Changed += new ChangedEventHandler(ListChanged);
        }

        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list
            List.Changed -= new ChangedEventHandler(ListChanged);
            List = null;
        }
    }

    class Test
    {
        public static void Main(string[] a)
        {
            ListWithChangedEvent list = new ListWithChangedEvent();

            EventListner ev = new EventListner( list );

            list.Add("item1");
            list.Clear();
            ev.Detach();
        }
    }
}