//HintName: G.Models.ToolControllerFindAllResponseItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerFindAllResponseItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apiRequest")]
        ApiRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash")]
        Bash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer")]
        Computer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dtmf")]
        Dtmf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="endCall")]
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ghl")]
        Ghl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.calendar.availability.check")]
        GohighlevelCalendarAvailabilityCheck,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.calendar.event.create")]
        GohighlevelCalendarEventCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.contact.create")]
        GohighlevelContactCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.contact.get")]
        GohighlevelContactGet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.availability.check")]
        GoogleCalendarAvailabilityCheck,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.event.create")]
        GoogleCalendarEventCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.sheets.row.append")]
        GoogleSheetsRowAppend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="handoff")]
        Handoff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sipRequest")]
        SipRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack.message.send")]
        SlackMessageSend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sms")]
        Sms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="textEditor")]
        TextEditor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transferCall")]
        TransferCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail")]
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