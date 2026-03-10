//HintName: G.JsonConverters.Nodes.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class NodesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Nodes>
    {
        /// <inheritdoc />
        public override global::G.Nodes Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentWorkflowRequestModelNodesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentWorkflowRequestModelNodesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentWorkflowRequestModelNodesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowStartNodeModelInput? start = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.Start)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStartNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStartNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowStartNodeModelInput)}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowEndNodeModelInput? end = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEndNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEndNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowEndNodeModelInput)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowPhoneNumberNodeModelInput? phoneNumber = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.PhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowPhoneNumberNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowPhoneNumberNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowPhoneNumberNodeModelInput)}");
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowOverrideAgentNodeModelInput? overrideAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.OverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowOverrideAgentNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowOverrideAgentNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowOverrideAgentNodeModelInput)}");
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowStandaloneAgentNodeModelInput? standaloneAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.StandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStandaloneAgentNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStandaloneAgentNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowStandaloneAgentNodeModelInput)}");
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolNodeModelInput? tool = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNodeModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolNodeModelInput)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Nodes(
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
            global::G.Nodes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStartNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStartNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowStartNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEndNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEndNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowEndNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
            else if (value.IsPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowPhoneNumberNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowPhoneNumberNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowPhoneNumberNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeInfo);
            }
            else if (value.IsOverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowOverrideAgentNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowOverrideAgentNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowOverrideAgentNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeInfo);
            }
            else if (value.IsStandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowStandaloneAgentNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowStandaloneAgentNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowStandaloneAgentNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNodeModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNodeModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolNodeModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}