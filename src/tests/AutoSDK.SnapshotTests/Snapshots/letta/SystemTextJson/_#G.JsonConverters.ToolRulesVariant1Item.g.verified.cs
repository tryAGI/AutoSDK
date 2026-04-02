//HintName: G.JsonConverters.ToolRulesVariant1Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolRulesVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolRulesVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.ToolRulesVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentStateToolRulesVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.ChildToolRule? constrainChildTools = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools)
            {
                constrainChildTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChildToolRule>(ref reader, options);
            }
            global::G.InitToolRule? runFirst = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.RunFirst)
            {
                runFirst = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InitToolRule>(ref reader, options);
            }
            global::G.TerminalToolRule? exitLoop = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.ExitLoop)
            {
                exitLoop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TerminalToolRule>(ref reader, options);
            }
            global::G.ConditionalToolRule? conditional = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.Conditional)
            {
                conditional = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConditionalToolRule>(ref reader, options);
            }
            global::G.ContinueToolRule? continueLoop = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.ContinueLoop)
            {
                continueLoop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContinueToolRule>(ref reader, options);
            }
            global::G.RequiredBeforeExitToolRule? requiredBeforeExit = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit)
            {
                requiredBeforeExit = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequiredBeforeExitToolRule>(ref reader, options);
            }
            global::G.MaxCountPerStepToolRule? maxCountPerStep = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep)
            {
                maxCountPerStep = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MaxCountPerStepToolRule>(ref reader, options);
            }
            global::G.ParentToolRule? parentLastTool = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.ParentLastTool)
            {
                parentLastTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ParentToolRule>(ref reader, options);
            }
            global::G.RequiresApprovalToolRule? requiresApproval = default;
            if (discriminator?.Type == global::G.AgentStateToolRulesVariant1ItemDiscriminatorType.RequiresApproval)
            {
                requiresApproval = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequiresApprovalToolRule>(ref reader, options);
            }

            var __value = new global::G.ToolRulesVariant1Item(
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
            global::G.ToolRulesVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConstrainChildTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConstrainChildTools, typeof(global::G.ChildToolRule), options);
            }
            else if (value.IsRunFirst)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunFirst, typeof(global::G.InitToolRule), options);
            }
            else if (value.IsExitLoop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExitLoop, typeof(global::G.TerminalToolRule), options);
            }
            else if (value.IsConditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Conditional, typeof(global::G.ConditionalToolRule), options);
            }
            else if (value.IsContinueLoop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContinueLoop, typeof(global::G.ContinueToolRule), options);
            }
            else if (value.IsRequiredBeforeExit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredBeforeExit, typeof(global::G.RequiredBeforeExitToolRule), options);
            }
            else if (value.IsMaxCountPerStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCountPerStep, typeof(global::G.MaxCountPerStepToolRule), options);
            }
            else if (value.IsParentLastTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentLastTool, typeof(global::G.ParentToolRule), options);
            }
            else if (value.IsRequiresApproval)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiresApproval, typeof(global::G.RequiresApprovalToolRule), options);
            }
        }
    }
}