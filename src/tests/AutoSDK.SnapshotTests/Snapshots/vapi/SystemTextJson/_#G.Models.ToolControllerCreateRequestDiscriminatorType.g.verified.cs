//HintName: G.Models.ToolControllerCreateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerCreateRequestDiscriminatorType
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
    public static class ToolControllerCreateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerCreateRequestDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerCreateRequestDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerCreateRequestDiscriminatorType.Bash => "bash",
                ToolControllerCreateRequestDiscriminatorType.Code => "code",
                ToolControllerCreateRequestDiscriminatorType.Computer => "computer",
                ToolControllerCreateRequestDiscriminatorType.Dtmf => "dtmf",
                ToolControllerCreateRequestDiscriminatorType.EndCall => "endCall",
                ToolControllerCreateRequestDiscriminatorType.Function => "function",
                ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerCreateRequestDiscriminatorType.Handoff => "handoff",
                ToolControllerCreateRequestDiscriminatorType.Mcp => "mcp",
                ToolControllerCreateRequestDiscriminatorType.Query => "query",
                ToolControllerCreateRequestDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerCreateRequestDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerCreateRequestDiscriminatorType.Sms => "sms",
                ToolControllerCreateRequestDiscriminatorType.TextEditor => "textEditor",
                ToolControllerCreateRequestDiscriminatorType.TransferCall => "transferCall",
                ToolControllerCreateRequestDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerCreateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerCreateRequestDiscriminatorType.ApiRequest,
                "bash" => ToolControllerCreateRequestDiscriminatorType.Bash,
                "code" => ToolControllerCreateRequestDiscriminatorType.Code,
                "computer" => ToolControllerCreateRequestDiscriminatorType.Computer,
                "dtmf" => ToolControllerCreateRequestDiscriminatorType.Dtmf,
                "endCall" => ToolControllerCreateRequestDiscriminatorType.EndCall,
                "function" => ToolControllerCreateRequestDiscriminatorType.Function,
                "gohighlevel.calendar.availability.check" => ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerCreateRequestDiscriminatorType.Handoff,
                "mcp" => ToolControllerCreateRequestDiscriminatorType.Mcp,
                "query" => ToolControllerCreateRequestDiscriminatorType.Query,
                "sipRequest" => ToolControllerCreateRequestDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerCreateRequestDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerCreateRequestDiscriminatorType.Sms,
                "textEditor" => ToolControllerCreateRequestDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerCreateRequestDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerCreateRequestDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}