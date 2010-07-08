using System;
using Microsoft.Web.Publishing.Tasks;

namespace TransformXml {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("TransformXml.exe source.xml transform.xml destination.xml");

            XmlTransformableDocument document = new XmlTransformableDocument();
            document.PreserveWhitespace = true;
            document.Load(args[0]);

            XmlTransformation transformation;
            transformation = new XmlTransformation(args[1], new Logger());

            transformation.Apply(document);

            document.Save(args[2]);
        }
    }

    public class Logger : IXmlTransformationLogger {

        #region IXmlTransformationLogger Members

        public void EndSection(MessageType type, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void EndSection(string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogError(string file, int lineNumber, int linePosition, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogError(string file, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogError(string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogErrorFromException(Exception ex, string file, int lineNumber, int linePosition) {
        }

        public void LogErrorFromException(Exception ex, string file) {
        }

        public void LogErrorFromException(Exception ex) {
        }

        public void LogMessage(MessageType type, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogMessage(string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogWarning(string file, int lineNumber, int linePosition, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogWarning(string file, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void LogWarning(string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void StartSection(MessageType type, string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        public void StartSection(string message, params object[] messageArgs) {
            Console.WriteLine(message, messageArgs);
        }

        #endregion
    }
}
