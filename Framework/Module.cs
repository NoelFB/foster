﻿namespace Foster.Framework
{
    public abstract class Module
    {

        /// <summary>
        /// A lower priority is run first
        /// </summary>
        protected internal int Priority = 10000;
        protected internal int MainThreadId = 0;

        protected internal virtual void Created() { }
        protected internal virtual void Startup() { }
        protected internal virtual void Shutdown() { }

        protected internal virtual void BeforeUpdate() { }
        protected internal virtual void Update() { }
        protected internal virtual void AfterUpdate() { }

        protected internal virtual void BeforeRender() { }
        protected internal virtual void Render(Window window) { }
        protected internal virtual void AfterRender() { }

        protected internal virtual void Tick() { }

    }
}
