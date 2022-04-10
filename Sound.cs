using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Лабиринт
{
    static class Sound
    {
        static bool isHaveSounds = true;
        static SoundPlayer soundWin = new SoundPlayer(Properties.Resources.SoundWin);
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.SoundFail);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.SoundStart);
        static SoundPlayer soundTakeMoney = new SoundPlayer(Properties.Resources.TakeMoney);

        public static void enableSounds()
        {
            isHaveSounds = true;
        }

        public static void disableSounds()
        {
            isHaveSounds = false;
        }

        public static void playWin()
        {
            if(!isHaveSounds)
                return;
            soundWin.Play();
        }

        public static void playFail()
        {
            if (!isHaveSounds)
                return;
            soundFail.Play();
        }

        public static void playStart()
        {
            if (!isHaveSounds)
                return;
            soundStart.Play();
        }

        public static void playTakeMoney()
        {
            if (!isHaveSounds)
                return;
            soundTakeMoney.Play();
        }
    }
}
