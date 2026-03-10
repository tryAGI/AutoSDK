//HintName: G.JsonConverters.Nodes2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Nodes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Nodes2>
    {
        /// <inheritdoc />
        public override global::G.Nodes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentWorkflowResponseModelNodesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentWorkflowResponseModelNodesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentWorkflowResponseModelNodesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowStartNodeModelOutput? start = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.Start)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStartNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStartNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowStartNodeModelOutput)}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowEndNodeModelOutput? end = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEndNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEndNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowEndNodeModelOutput)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowPhoneNumberNodeModelOutput? phoneNumber = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowPhoneNumberNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowPhoneNumberNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowPhoneNumberNodeModelOutput)}");
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowOverrideAgentNodeModelOutput? overrideAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowOverrideAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowOverrideAgentNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowOverrideAgentNodeModelOutput)}");
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStandaloneAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStandaloneAgentNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowStandaloneAgentNodeModelOutput)}");
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolNodeModelOutput? tool = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolNodeModelOutput)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Nodes2(
                discriminator?.Type,
                start,

                end,

                phoneNumber,

                overrideAgent,

                standaloneAgent,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Nodes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStartNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStartNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowStartNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEndNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEndNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowEndNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
            else if (value.IsPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowPhoneNumberNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowPhoneNumberNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowPhoneNumberNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeInfo);
            }
            else if (value.IsOverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowOverrideAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowOverrideAgentNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowOverrideAgentNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeInfo);
            }
            else if (value.IsStandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStandaloneAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStandaloneAgentNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowStandaloneAgentNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}