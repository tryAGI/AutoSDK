//HintName: G.Models.ToolControllerUpdateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerUpdateRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiRequest,
        /// <summary>
        /// 
        /// </summary>
        Bash,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Computer,
        /// <summary>
        /// 
        /// </summary>
        Dtmf,
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        GohighlevelCalendarAvailabilityCheck,
        /// <summary>
        /// 
        /// </summary>
        GohighlevelCalendarEventCreate,
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactCreate,
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarAvailabilityCheck,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarEventCreate,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsRowAppend,
        /// <summary>
        /// 
        /// </summary>
        Handoff,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        SipRequest,
        /// <summary>
        /// 
        /// </summary>
        SlackMessageSend,
        /// <summary>
        /// 
        /// </summary>
        Sms,
        /// <summary>
        /// 
        /// </summary>
        TextEditor,
        /// <summary>
        /// 
        /// </summary>
        TransferCall,
        /// <summary>
        /// 
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolControllerUpdateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerUpdateRequestDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerUpdateRequestDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerUpdateRequestDiscriminatorType.Bash => "bash",
                ToolControllerUpdateRequestDiscriminatorType.Code => "code",
                ToolControllerUpdateRequestDiscriminatorType.Computer => "computer",
                ToolControllerUpdateRequestDiscriminatorType.Dtmf => "dtmf",
                ToolControllerUpdateRequestDiscriminatorType.EndCall => "endCall",
                ToolControllerUpdateRequestDiscriminatorType.Function => "function",
                ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerUpdateRequestDiscriminatorType.Handoff => "handoff",
                ToolControllerUpdateRequestDiscriminatorType.Mcp => "mcp",
                ToolControllerUpdateRequestDiscriminatorType.Query => "query",
                ToolControllerUpdateRequestDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerUpdateRequestDiscriminatorType.Sms => "sms",
                ToolControllerUpdateRequestDiscriminatorType.TextEditor => "textEditor",
                ToolControllerUpdateRequestDiscriminatorType.TransferCall => "transferCall",
                ToolControllerUpdateRequestDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerUpdateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerUpdateRequestDiscriminatorType.ApiRequest,
                "bash" => ToolControllerUpdateRequestDiscriminatorType.Bash,
                "code" => ToolControllerUpdateRequestDiscriminatorType.Code,
                "computer" => ToolControllerUpdateRequestDiscriminatorType.Computer,
                "dtmf" => ToolControllerUpdateRequestDiscriminatorType.Dtmf,
                "endCall" => ToolControllerUpdateRequestDiscriminatorType.EndCall,
                "function" => ToolControllerUpdateRequestDiscriminatorType.Function,
                "gohighlevel.calendar.availability.check" => ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerUpdateRequestDiscriminatorType.Handoff,
                "mcp" => ToolControllerUpdateRequestDiscriminatorType.Mcp,
                "query" => ToolControllerUpdateRequestDiscriminatorType.Query,
                "sipRequest" => ToolControllerUpdateRequestDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerUpdateRequestDiscriminatorType.Sms,
                "textEditor" => ToolControllerUpdateRequestDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerUpdateRequestDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerUpdateRequestDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}