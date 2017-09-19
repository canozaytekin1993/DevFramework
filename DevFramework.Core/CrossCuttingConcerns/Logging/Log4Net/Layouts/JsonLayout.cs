using System.IO;
using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Layout
{
    public class JsonLayout:LayoutSkeleton
    {
        public override void ActivateOptions()
        {
            
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var LogEvent = new SerializableLogEvent(loggingEvent);

            var json = JsonConvert.SerializeObject(LogEvent,Formatting.Indented);
            writer.WriteLine(json);
        }
    }
}