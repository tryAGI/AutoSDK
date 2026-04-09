//HintName: G.JsonConverters.ToolRulesVariant1Item3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolRulesVariant1Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolRulesVariant1Item3>
    {
        /// <inheritdoc />
        public override global::G.ToolRulesVariant1Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ChildToolRule? constrainChildTools = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChildToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChildToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChildToolRule)}");
                constrainChildTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InitToolRule? runFirst = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RunFirst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InitToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InitToolRule)}");
                runFirst = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TerminalToolRule? exitLoop = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ExitLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TerminalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TerminalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TerminalToolRule)}");
                exitLoop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConditionalToolRule? conditional = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.Conditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConditionalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConditionalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConditionalToolRule)}");
                conditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContinueToolRule? continueLoop = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ContinueLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinueToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinueToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContinueToolRule)}");
                continueLoop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequiredBeforeExitToolRule? requiredBeforeExit = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequiredBeforeExitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequiredBeforeExitToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequiredBeforeExitToolRule)}");
                requiredBeforeExit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MaxCountPerStepToolRule? maxCountPerStep = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MaxCountPerStepToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MaxCountPerStepToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MaxCountPerStepToolRule)}");
                maxCountPerStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ParentToolRule? parentLastTool = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ParentLastTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ParentToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ParentToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ParentToolRule)}");
                parentLastTool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequiresApprovalToolRule? requiresApproval = default;
            if (discriminator?.Type == global::G.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiresApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequiresApprovalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequiresApprovalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequiresApprovalToolRule)}");
                requiresApproval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolRulesVariant1Item3(
                discriminator?.Type,
                constrainChildTools,

                runFirst,

                exitLoop,

                conditional,

                continueLoop,

                requiredBeforeExit,

                maxCountPerStep,

                parentLastTool,

                requiresApproval
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolRulesVariant1Item3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConstrainChildTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChildToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChildToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChildToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConstrainChildTools!, typeInfo);
            }
            else if (value.IsRunFirst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InitToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InitToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunFirst!, typeInfo);
            }
            else if (value.IsExitLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TerminalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TerminalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TerminalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExitLoop!, typeInfo);
            }
            else if (value.IsConditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConditionalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConditionalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConditionalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Conditional!, typeInfo);
            }
            else if (value.IsContinueLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinueToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinueToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContinueToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContinueLoop!, typeInfo);
            }
            else if (value.IsRequiredBeforeExit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequiredBeforeExitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequiredBeforeExitToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequiredBeforeExitToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredBeforeExit!, typeInfo);
            }
            else if (value.IsMaxCountPerStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MaxCountPerStepToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MaxCountPerStepToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MaxCountPerStepToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCountPerStep!, typeInfo);
            }
            else if (value.IsParentLastTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ParentToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ParentToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ParentToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentLastTool!, typeInfo);
            }
            else if (value.IsRequiresApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequiresApprovalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequiresApprovalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequiresApprovalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiresApproval!, typeInfo);
            }
        }
    }
}