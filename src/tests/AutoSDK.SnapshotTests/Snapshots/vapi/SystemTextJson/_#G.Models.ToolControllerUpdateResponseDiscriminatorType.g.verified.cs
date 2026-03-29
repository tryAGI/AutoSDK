//HintName: G.Models.ToolControllerUpdateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerUpdateResponseDiscriminatorType
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
        Ghl,
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
    public static class ToolControllerUpdateResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerUpdateResponseDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerUpdateResponseDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerUpdateResponseDiscriminatorType.Bash => "bash",
                ToolControllerUpdateResponseDiscriminatorType.Code => "code",
                ToolControllerUpdateResponseDiscriminatorType.Computer => "computer",
                ToolControllerUpdateResponseDiscriminatorType.Dtmf => "dtmf",
                ToolControllerUpdateResponseDiscriminatorType.EndCall => "endCall",
                ToolControllerUpdateResponseDiscriminatorType.Function => "function",
                ToolControllerUpdateResponseDiscriminatorType.Ghl => "ghl",
                ToolControllerUpdateResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerUpdateResponseDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerUpdateResponseDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerUpdateResponseDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerUpdateResponseDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerUpdateResponseDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerUpdateResponseDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerUpdateResponseDiscriminatorType.Handoff => "handoff",
                ToolControllerUpdateResponseDiscriminatorType.Mcp => "mcp",
                ToolControllerUpdateResponseDiscriminatorType.Query => "query",
                ToolControllerUpdateResponseDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerUpdateResponseDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerUpdateResponseDiscriminatorType.Sms => "sms",
                ToolControllerUpdateResponseDiscriminatorType.TextEditor => "textEditor",
                ToolControllerUpdateResponseDiscriminatorType.TransferCall => "transferCall",
                ToolControllerUpdateResponseDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerUpdateResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerUpdateResponseDiscriminatorType.ApiRequest,
                "bash" => ToolControllerUpdateResponseDiscriminatorType.Bash,
                "code" => ToolControllerUpdateResponseDiscriminatorType.Code,
                "computer" => ToolControllerUpdateResponseDiscriminatorType.Computer,
                "dtmf" => ToolControllerUpdateResponseDiscriminatorType.Dtmf,
                "endCall" => ToolControllerUpdateResponseDiscriminatorType.EndCall,
                "function" => ToolControllerUpdateResponseDiscriminatorType.Function,
                "ghl" => ToolControllerUpdateResponseDiscriminatorType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolControllerUpdateResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerUpdateResponseDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerUpdateResponseDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerUpdateResponseDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerUpdateResponseDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerUpdateResponseDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerUpdateResponseDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerUpdateResponseDiscriminatorType.Handoff,
                "mcp" => ToolControllerUpdateResponseDiscriminatorType.Mcp,
                "query" => ToolControllerUpdateResponseDiscriminatorType.Query,
                "sipRequest" => ToolControllerUpdateResponseDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerUpdateResponseDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerUpdateResponseDiscriminatorType.Sms,
                "textEditor" => ToolControllerUpdateResponseDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerUpdateResponseDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerUpdateResponseDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}