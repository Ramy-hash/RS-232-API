using System;

namespace RS232_API
{
    abstract public class Projector
    {
        protected String Make;
        protected String Model; 
        public abstract void ON();
        public abstract void OFF();
        public abstract void Generation();
        public abstract void Name();   
    }
    
}
