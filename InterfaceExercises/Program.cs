using System;

namespace InterfaceExercises
{
    class Program
    {
        public interface IPlayable
        {
            void Stop()
            {
                Console.WriteLine("Default implementation ..... ");
            }
            void Play();
            void Pause();
        }
        public class DvdPlayer : IPlayable
        {
            public void Play()
            {
                Console.WriteLine("DVD player is playing ...");
            }

            public void Pause()
            {
                Console.WriteLine("DVD player is playing ... ");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
