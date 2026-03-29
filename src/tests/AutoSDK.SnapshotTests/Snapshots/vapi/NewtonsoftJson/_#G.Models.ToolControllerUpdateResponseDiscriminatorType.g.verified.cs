//HintName: G.Models.ToolControllerUpdateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerUpdateResponseDiscriminatorType
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