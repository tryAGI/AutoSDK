//HintName: G.Models.ConversationInitiationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum representing the possible sources for conversation initiation.
    /// </summary>
    public enum ConversationInitiationSource
    {
        /// <summary>
        /// 
        /// </summary>
        AndroidSdk,
        /// <summary>
        /// 
        /// </summary>
        FlutterSdk,
        /// <summary>
        /// 
        /// </summary>
        Genesys,
        /// <summary>
        /// 
        /// </summary>
        JsSdk,
        /// <summary>
        /// 
        /// </summary>
        NodeJsSdk,
        /// <summary>
        /// 
        /// </summary>
        PythonSdk,
        /// <summary>
        /// 
        /// </summary>
        ReactNativeSdk,
        /// <summary>
        /// 
        /// </summary>
        ReactSdk,
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        SlackIntegration,
        /// <summary>
        /// 
        /// </summary>
        SwiftSdk,
        /// <summary>
        /// 
        /// </summary>
        TemplatePreview,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Whatsapp,
        /// <summary>
        /// 
        /// </summary>
        Widget,
        /// <summary>
        /// 
        /// </summary>
        ZendeskIntegration,
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
                ConversationInitiationSource.AndroidSdk => "android_sdk",
                ConversationInitiationSource.FlutterSdk => "flutter_sdk",
                ConversationInitiationSource.Genesys => "genesys",
                ConversationInitiationSource.JsSdk => "js_sdk",
                ConversationInitiationSource.NodeJsSdk => "node_js_sdk",
                ConversationInitiationSource.PythonSdk => "python_sdk",
                ConversationInitiationSource.ReactNativeSdk => "react_native_sdk",
                ConversationInitiationSource.ReactSdk => "react_sdk",
                ConversationInitiationSource.SipTrunk => "sip_trunk",
                ConversationInitiationSource.SlackIntegration => "slack_integration",
                ConversationInitiationSource.SwiftSdk => "swift_sdk",
                ConversationInitiationSource.TemplatePreview => "template_preview",
                ConversationInitiationSource.Twilio => "twilio",
                ConversationInitiationSource.Unknown => "unknown",
                ConversationInitiationSource.Whatsapp => "whatsapp",
                ConversationInitiationSource.Widget => "widget",
                ConversationInitiationSource.ZendeskIntegration => "zendesk_integration",
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
                "android_sdk" => ConversationInitiationSource.AndroidSdk,
                "flutter_sdk" => ConversationInitiationSource.FlutterSdk,
                "genesys" => ConversationInitiationSource.Genesys,
                "js_sdk" => ConversationInitiationSource.JsSdk,
                "node_js_sdk" => ConversationInitiationSource.NodeJsSdk,
                "python_sdk" => ConversationInitiationSource.PythonSdk,
                "react_native_sdk" => ConversationInitiationSource.ReactNativeSdk,
                "react_sdk" => ConversationInitiationSource.ReactSdk,
                "sip_trunk" => ConversationInitiationSource.SipTrunk,
                "slack_integration" => ConversationInitiationSource.SlackIntegration,
                "swift_sdk" => ConversationInitiationSource.SwiftSdk,
                "template_preview" => ConversationInitiationSource.TemplatePreview,
                "twilio" => ConversationInitiationSource.Twilio,
                "unknown" => ConversationInitiationSource.Unknown,
                "whatsapp" => ConversationInitiationSource.Whatsapp,
                "widget" => ConversationInitiationSource.Widget,
                "zendesk_integration" => ConversationInitiationSource.ZendeskIntegration,
                _ => null,
            };
        }
    }
}