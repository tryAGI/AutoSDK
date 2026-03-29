//HintName: G.Models.ToolControllerCreateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerCreateResponseDiscriminatorType
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
    public static class ToolControllerCreateResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerCreateResponseDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerCreateResponseDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerCreateResponseDiscriminatorType.Bash => "bash",
                ToolControllerCreateResponseDiscriminatorType.Code => "code",
                ToolControllerCreateResponseDiscriminatorType.Computer => "computer",
                ToolControllerCreateResponseDiscriminatorType.Dtmf => "dtmf",
                ToolControllerCreateResponseDiscriminatorType.EndCall => "endCall",
                ToolControllerCreateResponseDiscriminatorType.Function => "function",
                ToolControllerCreateResponseDiscriminatorType.Ghl => "ghl",
                ToolControllerCreateResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerCreateResponseDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerCreateResponseDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerCreateResponseDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerCreateResponseDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerCreateResponseDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerCreateResponseDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerCreateResponseDiscriminatorType.Handoff => "handoff",
                ToolControllerCreateResponseDiscriminatorType.Mcp => "mcp",
                ToolControllerCreateResponseDiscriminatorType.Query => "query",
                ToolControllerCreateResponseDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerCreateResponseDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerCreateResponseDiscriminatorType.Sms => "sms",
                ToolControllerCreateResponseDiscriminatorType.TextEditor => "textEditor",
                ToolControllerCreateResponseDiscriminatorType.TransferCall => "transferCall",
                ToolControllerCreateResponseDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerCreateResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerCreateResponseDiscriminatorType.ApiRequest,
                "bash" => ToolControllerCreateResponseDiscriminatorType.Bash,
                "code" => ToolControllerCreateResponseDiscriminatorType.Code,
                "computer" => ToolControllerCreateResponseDiscriminatorType.Computer,
                "dtmf" => ToolControllerCreateResponseDiscriminatorType.Dtmf,
                "endCall" => ToolControllerCreateResponseDiscriminatorType.EndCall,
                "function" => ToolControllerCreateResponseDiscriminatorType.Function,
                "ghl" => ToolControllerCreateResponseDiscriminatorType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolControllerCreateResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerCreateResponseDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerCreateResponseDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerCreateResponseDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerCreateResponseDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerCreateResponseDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerCreateResponseDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerCreateResponseDiscriminatorType.Handoff,
                "mcp" => ToolControllerCreateResponseDiscriminatorType.Mcp,
                "query" => ToolControllerCreateResponseDiscriminatorType.Query,
                "sipRequest" => ToolControllerCreateResponseDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerCreateResponseDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerCreateResponseDiscriminatorType.Sms,
                "textEditor" => ToolControllerCreateResponseDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerCreateResponseDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerCreateResponseDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}