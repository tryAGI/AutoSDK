//HintName: G.Models.ToolControllerRemoveResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolControllerRemoveResponseDiscriminatorType
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