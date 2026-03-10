//HintName: G.Models.ConversationInitiationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum representing the possible sources for conversation initiation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationInitiationSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="android_sdk")]
        AndroidSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="node_js_sdk")]
        NodeJsSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="react_native_sdk")]
        ReactNativeSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="react_sdk")]
        ReactSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="js_sdk")]
        JsSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python_sdk")]
        PythonSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="widget")]
        Widget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_trunk")]
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="genesys")]
        Genesys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift_sdk")]
        SwiftSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whatsapp")]
        Whatsapp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flutter_sdk")]
        FlutterSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zendesk_integration")]
        ZendeskIntegration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack_integration")]
        SlackIntegration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="template_preview")]
        TemplatePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationInitiationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationInitiationSource value)
        {
            return value switch
            {
                ConversationInitiationSource.Unknown => "unknown",
                ConversationInitiationSource.AndroidSdk => "android_sdk",
                ConversationInitiationSource.NodeJsSdk => "node_js_sdk",
                ConversationInitiationSource.ReactNativeSdk => "react_native_sdk",
                ConversationInitiationSource.ReactSdk => "react_sdk",
                ConversationInitiationSource.JsSdk => "js_sdk",
                ConversationInitiationSource.PythonSdk => "python_sdk",
                ConversationInitiationSource.Widget => "widget",
                ConversationInitiationSource.SipTrunk => "sip_trunk",
                ConversationInitiationSource.Twilio => "twilio",
                ConversationInitiationSource.Genesys => "genesys",
                ConversationInitiationSource.SwiftSdk => "swift_sdk",
                ConversationInitiationSource.Whatsapp => "whatsapp",
                ConversationInitiationSource.FlutterSdk => "flutter_sdk",
                ConversationInitiationSource.ZendeskIntegration => "zendesk_integration",
                ConversationInitiationSource.SlackIntegration => "slack_integration",
                ConversationInitiationSource.TemplatePreview => "template_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationInitiationSource? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => ConversationInitiationSource.Unknown,
                "android_sdk" => ConversationInitiationSource.AndroidSdk,
                "node_js_sdk" => ConversationInitiationSource.NodeJsSdk,
                "react_native_sdk" => ConversationInitiationSource.ReactNativeSdk,
                "react_sdk" => ConversationInitiationSource.ReactSdk,
                "js_sdk" => ConversationInitiationSource.JsSdk,
                "python_sdk" => ConversationInitiationSource.PythonSdk,
                "widget" => ConversationInitiationSource.Widget,
                "sip_trunk" => ConversationInitiationSource.SipTrunk,
                "twilio" => ConversationInitiationSource.Twilio,
                "genesys" => ConversationInitiationSource.Genesys,
                "swift_sdk" => ConversationInitiationSource.SwiftSdk,
                "whatsapp" => ConversationInitiationSource.Whatsapp,
                "flutter_sdk" => ConversationInitiationSource.FlutterSdk,
                "zendesk_integration" => ConversationInitiationSource.ZendeskIntegration,
                "slack_integration" => ConversationInitiationSource.SlackIntegration,
                "template_preview" => ConversationInitiationSource.TemplatePreview,
                _ => null,
            };
        }
    }
}