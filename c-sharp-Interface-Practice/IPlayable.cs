using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    /*
    Task 3:
Create an interface IPlayable with the following methods:

void Play()
void Pause()
void Stop()
Create two classes MusicPlayer and VideoPlayer
    that implement the IPlayable interface. Implement 
    the methods to control the playback of music and videos.
    */
    internal interface IPlayable
    {
        public void Play();
        public void Stop();
        public void Pause();
    }

    class MusicPlayer: IPlayable
    {
        public void Play() { Console.WriteLine("music is playing"); }
        public void Stop() { Console.WriteLine("music is stoped"); }
        public void Pause() { Console.WriteLine("music is paused"); }

    }
    class VideoPlayer: IPlayable
    {
        public void Play() { Console.WriteLine("Video is playing"); }
        public void Stop() { Console.WriteLine("Video is stoped"); }
        public void Pause() { Console.WriteLine("Video is paused"); }
    }
}
