using System;
using System.Diagnostics;
using System.Reflection;
using PostSharp.Aspects;

namespace DevFramework.Core.Aspects.Postsharp.PerformanceAspects
{
    /// <summary>
    /// Burada performans süresini hesaplamamız için bir sayaç oluşturmamız gerekir.
    /// Bunu yapmak için OnMethodBoundaryAspect den inherit almamız gerekir.
    /// Burada default değer olarak 5 saniye belirledik.
    /// </summary>
    [Serializable]
    public class PerformanceCounterAspect:OnMethodBoundaryAspect
    { 
        private int _interval;
        [NonSerialized()]
        private Stopwatch _stopwatch;

        public PerformanceCounterAspect(int interval=5)
        {
            _interval = interval;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }
        
        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch.Stop();
            if (_stopwatch.Elapsed.TotalSeconds>_interval)
            {
                Debug.WriteLine("Performance: {0}.{1}->>{2}",args.Method.DeclaringType.FullName,args.Method.DeclaringType.Name,_stopwatch.Elapsed.TotalSeconds);
            }
            _stopwatch.Restart();
            base.OnExit(args);
        }
    }
}