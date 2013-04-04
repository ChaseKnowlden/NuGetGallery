﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using NuGet;

namespace NuGetGallery.Diagnostics
{
    public interface IDiagnosticsSource
    {
        void Event(TraceEventType type, int id, string message, [CallerMemberName] string member = null, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0);
    }

    public static class DiagnosticsSourceExtensions
    {
        // That's right. Regions. Deal with it.
        #region TraceEventType.Critical
        public static void Critical(this IDiagnosticsSource self,
                                    string message,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Critical, id: 0, message: message, member: member, file: file, line: line);
        }

        public static void Critical(this IDiagnosticsSource self,
                                    string message,
                                    int id,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Critical, id, message, member, file, line);
        }

        public static void Critical(this IDiagnosticsSource self,
                                    Exception ex,
                                    string context,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            Critical(
                self,
                message: String.Format(CultureInfo.CurrentCulture, "{0}: {1}", context, ex),
                member: member,
                file: file,
                line: line);
        }
        #endregion
        #region TraceEventType.Error
        public static void Error(this IDiagnosticsSource self,
                                    string message,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Error, id: 0, message: message, member: member, file: file, line: line);
        }

        public static void Error(this IDiagnosticsSource self,
                                    string message,
                                    int id,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Error, id, message, member, file, line);
        }

        public static void Error(this IDiagnosticsSource self,
                                    Exception ex,
                                    string context,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            Error(
                self,
                message: String.Format(CultureInfo.CurrentCulture, "{0}: {1}", context, ex),
                member: member,
                file: file,
                line: line);
        }
        #endregion
        #region TraceEventType.Warning
        public static void Warning(this IDiagnosticsSource self,
                                    string message,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Warning, id: 0, message: message, member: member, file: file, line: line);
        }

        public static void Warning(this IDiagnosticsSource self,
                                    string message,
                                    int id,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Warning, id, message, member, file, line);
        }

        public static void Warning(this IDiagnosticsSource self,
                                    Exception ex,
                                    string context,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            Warning(
                self,
                message: String.Format(CultureInfo.CurrentCulture, "{0}: {1}", context, ex),
                member: member,
                file: file,
                line: line);
        }
        #endregion
        #region TraceEventType.Information
        public static void Information(this IDiagnosticsSource self,
                                    string message,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Information, id: 0, message: message, member: member, file: file, line: line);
        }

        public static void Information(this IDiagnosticsSource self,
                                    string message,
                                    int id,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Information, id, message, member, file, line);
        }

        public static void Information(this IDiagnosticsSource self,
                                    Exception ex,
                                    string context,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            Information(
                self,
                message: String.Format(CultureInfo.CurrentCulture, "{0}: {1}", context, ex),
                member: member,
                file: file,
                line: line);
        }
        #endregion
        #region TraceEventType.Verbose
        public static void Verbose(this IDiagnosticsSource self,
                                    string message,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Verbose, id: 0, message: message, member: member, file: file, line: line);
        }

        public static void Verbose(this IDiagnosticsSource self,
                                    string message,
                                    int id,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Verbose, id, message, member, file, line);
        }

        public static void Verbose(this IDiagnosticsSource self,
                                    Exception ex,
                                    string context,
                                    [CallerMemberName] string member = null,
                                    [CallerFilePath] string file = null,
                                    [CallerLineNumber] int line = 0)
        {
            Verbose(
                self,
                message: String.Format(CultureInfo.CurrentCulture, "{0}: {1}", context, ex),
                member: member,
                file: file,
                line: line);
        }
        #endregion

        public static IDisposable Activity(this IDiagnosticsSource self,
                                           string name,
                                           [CallerMemberName] string member = null,
                                           [CallerFilePath] string file = null,
                                           [CallerLineNumber] int line = 0)
        {
            self.Event(TraceEventType.Start,
                       id: 0,
                       message: String.Format(CultureInfo.CurrentCulture, "Starting {0}", name),
                       member: member,
                       file: file,
                       line: line);
            var stopMessage = String.Format(CultureInfo.CurrentCulture, "Starting {0}", name);
            return new DisposableAction(() =>
                self.Event(TraceEventType.Stop,
                            id: 0,
                            message: stopMessage,
                            member: member,
                            file: file,
                            line: line));
        }
    }
}