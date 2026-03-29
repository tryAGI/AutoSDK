//HintName: G.Models.ToolControllerFindOneResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerFindOneResponseDiscriminatorType
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
    public static class ToolControllerFindOneResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerFindOneResponseDiscriminatorType value)
        {
            return value switch
            {
                ToolControllerFindOneResponseDiscriminatorType.ApiRequest => "apiRequest",
                ToolControllerFindOneResponseDiscriminatorType.Bash => "bash",
                ToolControllerFindOneResponseDiscriminatorType.Code => "code",
                ToolControllerFindOneResponseDiscriminatorType.Computer => "computer",
                ToolControllerFindOneResponseDiscriminatorType.Dtmf => "dtmf",
                ToolControllerFindOneResponseDiscriminatorType.EndCall => "endCall",
                ToolControllerFindOneResponseDiscriminatorType.Function => "function",
                ToolControllerFindOneResponseDiscriminatorType.Ghl => "ghl",
                ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolControllerFindOneResponseDiscriminatorType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolControllerFindOneResponseDiscriminatorType.Handoff => "handoff",
                ToolControllerFindOneResponseDiscriminatorType.Mcp => "mcp",
                ToolControllerFindOneResponseDiscriminatorType.Query => "query",
                ToolControllerFindOneResponseDiscriminatorType.SipRequest => "sipRequest",
                ToolControllerFindOneResponseDiscriminatorType.SlackMessageSend => "slack.message.send",
                ToolControllerFindOneResponseDiscriminatorType.Sms => "sms",
                ToolControllerFindOneResponseDiscriminatorType.TextEditor => "textEditor",
                ToolControllerFindOneResponseDiscriminatorType.TransferCall => "transferCall",
                ToolControllerFindOneResponseDiscriminatorType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerFindOneResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolControllerFindOneResponseDiscriminatorType.ApiRequest,
                "bash" => ToolControllerFindOneResponseDiscriminatorType.Bash,
                "code" => ToolControllerFindOneResponseDiscriminatorType.Code,
                "computer" => ToolControllerFindOneResponseDiscriminatorType.Computer,
                "dtmf" => ToolControllerFindOneResponseDiscriminatorType.Dtmf,
                "endCall" => ToolControllerFindOneResponseDiscriminatorType.EndCall,
                "function" => ToolControllerFindOneResponseDiscriminatorType.Function,
                "ghl" => ToolControllerFindOneResponseDiscriminatorType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolControllerFindOneResponseDiscriminatorType.GoogleSheetsRowAppend,
                "handoff" => ToolControllerFindOneResponseDiscriminatorType.Handoff,
                "mcp" => ToolControllerFindOneResponseDiscriminatorType.Mcp,
                "query" => ToolControllerFindOneResponseDiscriminatorType.Query,
                "sipRequest" => ToolControllerFindOneResponseDiscriminatorType.SipRequest,
                "slack.message.send" => ToolControllerFindOneResponseDiscriminatorType.SlackMessageSend,
                "sms" => ToolControllerFindOneResponseDiscriminatorType.Sms,
                "textEditor" => ToolControllerFindOneResponseDiscriminatorType.TextEditor,
                "transferCall" => ToolControllerFindOneResponseDiscriminatorType.TransferCall,
                "voicemail" => ToolControllerFindOneResponseDiscriminatorType.Voicemail,
                _ => null,
            };
        }
    }
}