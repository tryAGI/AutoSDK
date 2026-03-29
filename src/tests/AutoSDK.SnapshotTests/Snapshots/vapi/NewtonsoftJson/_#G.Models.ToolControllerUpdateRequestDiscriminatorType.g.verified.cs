//HintName: G.Models.ToolControllerUpdateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerUpdateRequestDiscriminatorType
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