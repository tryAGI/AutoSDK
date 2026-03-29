//HintName: G.Models.ToolControllerFindAllResponseItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerFindAllResponseItemDiscriminatorType
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
    public static class ToolControllerFindAllResponseItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerFindAllResponseItemDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerFindAllResponseItemDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerFindAllResponseItemDiscriminatorType.Bash => "bash",
                ToolControllerFindAllResponseItemDiscriminatorType.Code => "code",
                ToolControllerFindAllResponseItemDiscriminatorType.Computer => "computer",
                ToolControllerFindAllResponseItemDiscriminatorType.Dtmf => "dtmf",
                ToolControllerFindAllResponseItemDiscriminatorType.EndCall => "endCall",
                ToolControllerFindAllResponseItemDiscriminatorType.Function => "function",
                ToolControllerFindAllResponseItemDiscriminatorType.Ghl => "ghl",
                ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerFindAllResponseItemDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerFindAllResponseItemDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerFindAllResponseItemDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerFindAllResponseItemDiscriminatorType.Handoff => "handoff",
                ToolControllerFindAllResponseItemDiscriminatorType.Mcp => "mcp",
                ToolControllerFindAllResponseItemDiscriminatorType.Query => "query",
                ToolControllerFindAllResponseItemDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerFindAllResponseItemDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerFindAllResponseItemDiscriminatorType.Sms => "sms",
                ToolControllerFindAllResponseItemDiscriminatorType.TextEditor => "textEditor",
                ToolControllerFindAllResponseItemDiscriminatorType.TransferCall => "transferCall",
                ToolControllerFindAllResponseItemDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerFindAllResponseItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerFindAllResponseItemDiscriminatorType.ApiRequest,
                "bash" => ToolControllerFindAllResponseItemDiscriminatorType.Bash,
                "code" => ToolControllerFindAllResponseItemDiscriminatorType.Code,
                "computer" => ToolControllerFindAllResponseItemDiscriminatorType.Computer,
                "dtmf" => ToolControllerFindAllResponseItemDiscriminatorType.Dtmf,
                "endCall" => ToolControllerFindAllResponseItemDiscriminatorType.EndCall,
                "function" => ToolControllerFindAllResponseItemDiscriminatorType.Function,
                "ghl" => ToolControllerFindAllResponseItemDiscriminatorType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerFindAllResponseItemDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerFindAllResponseItemDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerFindAllResponseItemDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerFindAllResponseItemDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerFindAllResponseItemDiscriminatorType.Handoff,
                "mcp" => ToolControllerFindAllResponseItemDiscriminatorType.Mcp,
                "query" => ToolControllerFindAllResponseItemDiscriminatorType.Query,
                "sipRequest" => ToolControllerFindAllResponseItemDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerFindAllResponseItemDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerFindAllResponseItemDiscriminatorType.Sms,
                "textEditor" => ToolControllerFindAllResponseItemDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerFindAllResponseItemDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerFindAllResponseItemDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}