﻿namespace LightNovelSnifferCore.Libs
{
    public interface IOutput
    {
        void Log(string text);
        void Progress(string text);
    }
}
