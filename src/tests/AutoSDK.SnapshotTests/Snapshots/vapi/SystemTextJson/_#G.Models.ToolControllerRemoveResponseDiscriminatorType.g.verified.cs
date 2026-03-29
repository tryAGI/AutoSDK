//HintName: G.Models.ToolControllerRemoveResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolControllerRemoveResponseDiscriminatorType
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
    public static class ToolControllerRemoveResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerRemoveResponseDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerRemoveResponseDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerRemoveResponseDiscriminatorType.Bash => "bash",
                ToolControllerRemoveResponseDiscriminatorType.Code => "code",
                ToolControllerRemoveResponseDiscriminatorType.Computer => "computer",
                ToolControllerRemoveResponseDiscriminatorType.Dtmf => "dtmf",
                ToolControllerRemoveResponseDiscriminatorType.EndCall => "endCall",
                ToolControllerRemoveResponseDiscriminatorType.Function => "function",
                ToolControllerRemoveResponseDiscriminatorType.Ghl => "ghl",
                ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerRemoveResponseDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerRemoveResponseDiscriminatorType.Handoff => "handoff",
                ToolControllerRemoveResponseDiscriminatorType.Mcp => "mcp",
                ToolControllerRemoveResponseDiscriminatorType.Query => "query",
                ToolControllerRemoveResponseDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerRemoveResponseDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerRemoveResponseDiscriminatorType.Sms => "sms",
                ToolControllerRemoveResponseDiscriminatorType.TextEditor => "textEditor",
                ToolControllerRemoveResponseDiscriminatorType.TransferCall => "transferCall",
                ToolControllerRemoveResponseDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerRemoveResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerRemoveResponseDiscriminatorType.ApiRequest,
                "bash" => ToolControllerRemoveResponseDiscriminatorType.Bash,
                "code" => ToolControllerRemoveResponseDiscriminatorType.Code,
                "computer" => ToolControllerRemoveResponseDiscriminatorType.Computer,
                "dtmf" => ToolControllerRemoveResponseDiscriminatorType.Dtmf,
                "endCall" => ToolControllerRemoveResponseDiscriminatorType.EndCall,
                "function" => ToolControllerRemoveResponseDiscriminatorType.Function,
                "ghl" => ToolControllerRemoveResponseDiscriminatorType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerRemoveResponseDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerRemoveResponseDiscriminatorType.Handoff,
                "mcp" => ToolControllerRemoveResponseDiscriminatorType.Mcp,
                "query" => ToolControllerRemoveResponseDiscriminatorType.Query,
                "sipRequest" => ToolControllerRemoveResponseDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerRemoveResponseDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerRemoveResponseDiscriminatorType.Sms,
                "textEditor" => ToolControllerRemoveResponseDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerRemoveResponseDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerRemoveResponseDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}