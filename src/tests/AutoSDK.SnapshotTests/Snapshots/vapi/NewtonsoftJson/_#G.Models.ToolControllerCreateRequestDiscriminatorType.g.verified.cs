//HintName: G.Models.ToolControllerCreateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerCreateRequestDiscriminatorType
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