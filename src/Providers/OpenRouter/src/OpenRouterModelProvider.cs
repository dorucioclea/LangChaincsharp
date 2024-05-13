using OpenAI.Constants;

namespace LangChain.Providers.OpenRouter;

/// <summary>
/// Contains all the OpenRouter models.
/// </summary>
public static class OpenRouterModelProvider
{
    private static Dictionary<OpenRouterModelIds, ChatModels> Models { get; set; } = new()
    {
        { OpenRouterModelIds.NousCapybara7BFree, new ChatModels("nousresearch/nous-capybara-7b:free",4096,0,0)},
        { OpenRouterModelIds.Mistral7BInstructFree, new ChatModels("mistralai/mistral-7b-instruct:free",32768,0,0)},
        { OpenRouterModelIds.OpenChat35Free, new ChatModels("openchat/openchat-7b:free",8192,0,0)},
        { OpenRouterModelIds.Mythomist7BFree, new ChatModels("gryphe/mythomist-7b:free",32768,0,0)},
        { OpenRouterModelIds.ToppyM7BFree, new ChatModels("undi95/toppy-m-7b:free",4096,0,0)},
        { OpenRouterModelIds.Cinematika7BAlphaFree, new ChatModels("openrouter/cinematika-7b:free",8000,0,0)},
        { OpenRouterModelIds.GoogleGemma7BFree, new ChatModels("google/gemma-7b-it:free",8192,0,0)},
        { OpenRouterModelIds.MetaLlama38BInstructFree, new ChatModels("meta-llama/llama-3-8b-instruct:free",8192,0,0)},
        { OpenRouterModelIds.Jetmoe8BFree, new ChatModels("jetmoe/jetmoe-8b-chat:free",4096,0,0)},
        { OpenRouterModelIds.PsyfighterV213B, new ChatModels("koboldai/psyfighter-13b-2",4096,0.001,0.001)},
        { OpenRouterModelIds.NeuralChat7BV31, new ChatModels("intel/neural-chat-7b",4096,0.005,0.005)},
        { OpenRouterModelIds.Mythomax13BNitro, new ChatModels("gryphe/mythomax-l2-13b:nitro",4096,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.PygmalionMythalion13B, new ChatModels("pygmalionai/mythalion-13b",8192,0.001125,0.001125)},
        { OpenRouterModelIds.Xwin70B, new ChatModels("xwin-lm/xwin-lm-70b",8192,0.00375,0.00375)},
        { OpenRouterModelIds.Goliath120B, new ChatModels("alpindale/goliath-120b",6144,0.009375,0.009375)},
        { OpenRouterModelIds.Noromaid20B, new ChatModels("neversleep/noromaid-20b",8192,0.00225,0.00225)},
        { OpenRouterModelIds.Mythomist7B, new ChatModels("gryphe/mythomist-7b",32768,0.000375,0.000375)},
        { OpenRouterModelIds.MidnightRose70B, new ChatModels("sophosympatheia/midnight-rose-70b",4096,0.009,0.009)},
        { OpenRouterModelIds.Fimbulvetr11BV2, new ChatModels("sao10k/fimbulvetr-11b-v2",8192,0.0005499000000000001,0.002826)},
        { OpenRouterModelIds.Llama3Lumimaid8B, new ChatModels("neversleep/llama-3-lumimaid-8b",24576,0.000225,0.00225)},
        { OpenRouterModelIds.RemmSlerp13BExtended, new ChatModels("undi95/remm-slerp-l2-13b:extended",6144,0.001125,0.001125)},
        { OpenRouterModelIds.Mythomax13BExtended, new ChatModels("gryphe/mythomax-l2-13b:extended",8192,0.001125,0.001125)},
        { OpenRouterModelIds.MetaLlama38BInstructExtended, new ChatModels("meta-llama/llama-3-8b-instruct:extended",16384,0.000225,0.00225)},
        { OpenRouterModelIds.Llama3Lumimaid8BExtended, new ChatModels("neversleep/llama-3-lumimaid-8b:extended",24576,0.000225,0.00225)},
        { OpenRouterModelIds.MancerWeaverAlpha, new ChatModels("mancer/weaver",8000,0.003375,0.003375)},
        { OpenRouterModelIds.NousCapybara7B, new ChatModels("nousresearch/nous-capybara-7b",4096,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.MetaCodellama34BInstruct, new ChatModels("meta-llama/codellama-34b-instruct",8192,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.MetaCodellama70BInstruct, new ChatModels("codellama/codellama-70b-instruct",2048,0.0008100000000000001,0.0008100000000000001)},
        { OpenRouterModelIds.PhindCodellama34BV2, new ChatModels("phind/phind-codellama-34b",4096,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.MistralOpenOrca7B, new ChatModels("open-orca/mistral-7b-openorca",8192,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.OpenHermes2Mistral7B, new ChatModels("teknium/openhermes-2-mistral-7b",4096,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.RemmSlerp13B, new ChatModels("undi95/remm-slerp-l2-13b",4096,0.00027,0.00027)},
        { OpenRouterModelIds.Cinematika7BAlpha, new ChatModels("openrouter/cinematika-7b",8000,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.Yi34BChat, new ChatModels("01-ai/yi-34b-chat",4096,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.Yi34BBase, new ChatModels("01-ai/yi-34b",4096,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.Yi6BBase, new ChatModels("01-ai/yi-6b",4096,0.000126,0.000126)},
        { OpenRouterModelIds.StripedhyenaNous7B, new ChatModels("togethercomputer/stripedhyena-nous-7b",32768,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.StripedhyenaHessian7BBase, new ChatModels("togethercomputer/stripedhyena-hessian-7b",32768,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.Mixtral8X7BBase, new ChatModels("mistralai/mixtral-8x7b",32768,0.00054,0.00054)},
        { OpenRouterModelIds.NousHermes2Yi34B, new ChatModels("nousresearch/nous-hermes-yi-34b",4096,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.NousHermes2Mixtral8X7BSft, new ChatModels("nousresearch/nous-hermes-2-mixtral-8x7b-sft",32768,0.00054,0.00054)},
        { OpenRouterModelIds.NousHermes2Mistral7BDpo, new ChatModels("nousresearch/nous-hermes-2-mistral-7b-dpo",8192,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.Olmo7BInstruct, new ChatModels("allenai/olmo-7b-instruct",2048,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.SnowflakeArcticInstruct, new ChatModels("snowflake/snowflake-arctic-instruct",4096,0.00216,0.00216)},
        { OpenRouterModelIds.Qwen15110BChat, new ChatModels("qwen/qwen-110b-chat",32768,0.0016200000000000001,0.0016200000000000001)},
        { OpenRouterModelIds.Qwen1532BChat, new ChatModels("qwen/qwen-32b-chat",32768,0.0007199999999999999,0.0007199999999999999)},
        { OpenRouterModelIds.Qwen1514BChat, new ChatModels("qwen/qwen-14b-chat",32768,0.00027,0.00027)},
        { OpenRouterModelIds.Qwen157BChat, new ChatModels("qwen/qwen-7b-chat",32768,0.00017999999999999998,0.00017999999999999998)},
        { OpenRouterModelIds.Qwen154BChat, new ChatModels("qwen/qwen-4b-chat",32768,8.999999999999999E-05,8.999999999999999E-05)},
        { OpenRouterModelIds.Mixtral8X7BInstructNitro, new ChatModels("mistralai/mixtral-8x7b-instruct:nitro",32768,0.00054,0.00054)},
        { OpenRouterModelIds.OpenAiGpt35Turbo, new ChatModels("openai/gpt-3.5-turbo",16385,0.0005,0.0015)},
        { OpenRouterModelIds.OpenAiGpt35Turbo16K0125, new ChatModels("openai/gpt-3.5-turbo-0125",16385,0.0005,0.0015)},
        { OpenRouterModelIds.OpenAiGpt35Turbo16K, new ChatModels("openai/gpt-3.5-turbo-16k",16385,0.003,0.004)},
        { OpenRouterModelIds.OpenAiGpt4Turbo, new ChatModels("openai/gpt-4-turbo",128000,0.01,0.03)},
        { OpenRouterModelIds.OpenAiGpt4TurboPreview, new ChatModels("openai/gpt-4-turbo-preview",128000,0.01,0.03)},
        { OpenRouterModelIds.OpenAiGpt4, new ChatModels("openai/gpt-4",8191,0.03,0.06)},
        { OpenRouterModelIds.OpenAiGpt432K, new ChatModels("openai/gpt-4-32k",32767,0.06,0.12)},
        { OpenRouterModelIds.OpenAiGpt4Vision, new ChatModels("openai/gpt-4-vision-preview",128000,0.01,0.03)},
        { OpenRouterModelIds.OpenAiGpt35TurboInstruct, new ChatModels("openai/gpt-3.5-turbo-instruct",4095,0.0015,0.002)},
        { OpenRouterModelIds.GooglePalm2Chat, new ChatModels("google/palm-2-chat-bison",25804,0.00025,0.0005)},
        { OpenRouterModelIds.GooglePalm2CodeChat, new ChatModels("google/palm-2-codechat-bison",20070,0.00025,0.0005)},
        { OpenRouterModelIds.GooglePalm2Chat32K, new ChatModels("google/palm-2-chat-bison-32k",91750,0.00025,0.0005)},
        { OpenRouterModelIds.GooglePalm2CodeChat32K, new ChatModels("google/palm-2-codechat-bison-32k",91750,0.00025,0.0005)},
        { OpenRouterModelIds.GoogleGeminiPro10, new ChatModels("google/gemini-pro",91728,0.000125,0.000375)},
        { OpenRouterModelIds.GoogleGeminiProVision10, new ChatModels("google/gemini-pro-vision",45875,0.000125,0.000375)},
        { OpenRouterModelIds.GoogleGeminiPro15Preview, new ChatModels("google/gemini-pro-1.5",2800000,0.0025,0.0075)},
        { OpenRouterModelIds.PerplexityPplx70BOnline, new ChatModels("perplexity/pplx-70b-online",4096,0.001,0.001)},
        { OpenRouterModelIds.PerplexityPplx7BOnline, new ChatModels("perplexity/pplx-7b-online",4096,0.0002,0.0002)},
        { OpenRouterModelIds.PerplexityPplx7BChat, new ChatModels("perplexity/pplx-7b-chat",8192,0.0002,0.0002)},
        { OpenRouterModelIds.PerplexityPplx70BChat, new ChatModels("perplexity/pplx-70b-chat",4096,0.001,0.001)},
        { OpenRouterModelIds.PerplexitySonar7B, new ChatModels("perplexity/sonar-small-chat",16384,0.0002,0.0002)},
        { OpenRouterModelIds.PerplexitySonar8X7B, new ChatModels("perplexity/sonar-medium-chat",16384,0.0006,0.0006)},
        { OpenRouterModelIds.PerplexitySonar7BOnline, new ChatModels("perplexity/sonar-small-online",12000,0.0002,0.0002)},
        { OpenRouterModelIds.PerplexitySonar8X7BOnline, new ChatModels("perplexity/sonar-medium-online",12000,0.0006,0.0006)},
        { OpenRouterModelIds.Firellava13B, new ChatModels("fireworks/firellava-13b",4096,0.0002,0.0002)},
        { OpenRouterModelIds.AnthropicClaude3Opus, new ChatModels("anthropic/claude-3-opus",200000,0.015,0.075)},
        { OpenRouterModelIds.AnthropicClaude3Sonnet, new ChatModels("anthropic/claude-3-sonnet",200000,0.003,0.015)},
        { OpenRouterModelIds.AnthropicClaude3Haiku, new ChatModels("anthropic/claude-3-haiku",200000,0.00025,0.00125)},
        { OpenRouterModelIds.AnthropicClaudeV2, new ChatModels("anthropic/claude-2",200000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeV20, new ChatModels("anthropic/claude-2.0",100000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeV21, new ChatModels("anthropic/claude-2.1",200000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeInstantV1, new ChatModels("anthropic/claude-instant-1",100000,0.0008,0.0024)},
        { OpenRouterModelIds.AnthropicClaude3OpusSelfModerated, new ChatModels("anthropic/claude-3-opus:beta",200000,0.015,0.075)},
        { OpenRouterModelIds.AnthropicClaude3SonnetSelfModerated, new ChatModels("anthropic/claude-3-sonnet:beta",200000,0.003,0.015)},
        { OpenRouterModelIds.AnthropicClaude3HaikuSelfModerated, new ChatModels("anthropic/claude-3-haiku:beta",200000,0.00025,0.00125)},
        { OpenRouterModelIds.AnthropicClaudeV2SelfModerated, new ChatModels("anthropic/claude-2:beta",200000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeV20SelfModerated, new ChatModels("anthropic/claude-2.0:beta",100000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeV21SelfModerated, new ChatModels("anthropic/claude-2.1:beta",200000,0.008,0.024)},
        { OpenRouterModelIds.AnthropicClaudeInstantV1SelfModerated, new ChatModels("anthropic/claude-instant-1:beta",100000,0.0008,0.0024)},
        { OpenRouterModelIds.MetaLlamaV213BChat, new ChatModels("meta-llama/llama-2-13b-chat",4096,0.00013000000000000002,0.00013000000000000002)},
        { OpenRouterModelIds.MetaLlamaV270BChat, new ChatModels("meta-llama/llama-2-70b-chat",4096,0.00064,0.0008)},
        { OpenRouterModelIds.NousHermes13B, new ChatModels("nousresearch/nous-hermes-llama2-13b",4096,0.00026000000000000003,0.00026000000000000003)},
        { OpenRouterModelIds.NousCapybara34B, new ChatModels("nousresearch/nous-capybara-34b",32768,0.0009,0.0009)},
        { OpenRouterModelIds.Airoboros70B, new ChatModels("jondurbin/airoboros-l2-70b",4096,0.0007,0.0009)},
        { OpenRouterModelIds.ChronosHermes13BV2, new ChatModels("austism/chronos-hermes-13b",4096,0.00013000000000000002,0.00013000000000000002)},
        { OpenRouterModelIds.Mistral7BInstruct, new ChatModels("mistralai/mistral-7b-instruct",32768,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.OpenHermes25Mistral7B, new ChatModels("teknium/openhermes-2.5-mistral-7b",4096,0.00017,0.00017)},
        { OpenRouterModelIds.Mythomax13B, new ChatModels("gryphe/mythomax-l2-13b",4096,0.00013000000000000002,0.00013000000000000002)},
        { OpenRouterModelIds.HuggingFaceZephyr7B, new ChatModels("huggingfaceh4/zephyr-7b-beta",4096,0.0002,0.0002)},
        { OpenRouterModelIds.OpenChat35, new ChatModels("openchat/openchat-7b",8192,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.ToppyM7B, new ChatModels("undi95/toppy-m-7b",4096,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.Lzlv70B, new ChatModels("lizpreciatior/lzlv-70b-fp16-hf",4096,0.0005899999999999999,0.00079)},
        { OpenRouterModelIds.Mixtral8X7BInstruct, new ChatModels("mistralai/mixtral-8x7b-instruct",32768,0.00023999999999999998,0.00023999999999999998)},
        { OpenRouterModelIds.NoromaidMixtral8X7BInstruct, new ChatModels("neversleep/noromaid-mixtral-8x7b-instruct",8000,0.008,0.008)},
        { OpenRouterModelIds.NousHermes2Mixtral8X7BDpo, new ChatModels("nousresearch/nous-hermes-2-mixtral-8x7b-dpo",32768,0.00027,0.00027)},
        { OpenRouterModelIds.RwkvV5World3B, new ChatModels("rwkv/rwkv-5-world-3b",10000,0,0)},
        { OpenRouterModelIds.RwkvV53BAiTown, new ChatModels("recursal/rwkv-5-3b-ai-town",10000,0,0)},
        { OpenRouterModelIds.RwkvV5Eagle7B, new ChatModels("recursal/eagle-7b",10000,0,0)},
        { OpenRouterModelIds.GoogleGemma7B, new ChatModels("google/gemma-7b-it",8192,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.MetaLlama38BInstruct, new ChatModels("meta-llama/llama-3-8b-instruct",8192,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.MetaLlama370BInstruct, new ChatModels("meta-llama/llama-3-70b-instruct",8192,0.0005899999999999999,0.00079)},
        { OpenRouterModelIds.Wizardlm28X22b, new ChatModels("microsoft/wizardlm-2-8x22b",65536,0.00065,0.00065)},
        { OpenRouterModelIds.Wizardlm27B, new ChatModels("microsoft/wizardlm-2-7b",32000,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.MistralMixtral8X22BBase, new ChatModels("mistralai/mixtral-8x22b",65536,0.0009,0.0009)},
        { OpenRouterModelIds.MistralMixtral8X22bInstruct, new ChatModels("mistralai/mixtral-8x22b-instruct",65536,0.00065,0.00065)},
        { OpenRouterModelIds.LynnLlama3Soliloquy8BV2, new ChatModels("lynn/soliloquy-l3",24576,5E-05,5E-05)},
        { OpenRouterModelIds.Dolphin26Mixtral8X7B, new ChatModels("cognitivecomputations/dolphin-mixtral-8x7b",32768,0.0005,0.0005)},
        { OpenRouterModelIds.DatabricksDbrx132BInstruct, new ChatModels("databricks/dbrx-instruct",32768,0.0006,0.0006)},
        { OpenRouterModelIds.Jetmoe8B, new ChatModels("jetmoe/jetmoe-8b-chat",4096,0.0001,0.0001)},
        { OpenRouterModelIds.LlavaV1634B, new ChatModels("liuhaotian/llava-yi-34b",4096,0.0009,0.0009)},
        { OpenRouterModelIds.Qwen1572BChat, new ChatModels("qwen/qwen-72b-chat",32768,0.0009,0.0009)},
        { OpenRouterModelIds.HuggingFaceZephyr7BFree, new ChatModels("huggingfaceh4/zephyr-7b-beta:free",4096,0,0)},
        { OpenRouterModelIds.MetaLlamaV270BChatNitro, new ChatModels("meta-llama/llama-2-70b-chat:nitro",4096,0.0009,0.0009)},
        { OpenRouterModelIds.Mistral7BInstructNitro, new ChatModels("mistralai/mistral-7b-instruct:nitro",32768,0.0002,0.0002)},
        { OpenRouterModelIds.GoogleGemma7BNitro, new ChatModels("google/gemma-7b-it:nitro",8192,0.0002,0.0002)},
        { OpenRouterModelIds.ToppyM7BNitro, new ChatModels("undi95/toppy-m-7b:nitro",4096,7.000000000000001E-05,7.000000000000001E-05)},
        { OpenRouterModelIds.Wizardlm28X22bNitro, new ChatModels("microsoft/wizardlm-2-8x22b:nitro",65536,0.001,0.001)},
        { OpenRouterModelIds.MetaLlama38BInstructNitro, new ChatModels("meta-llama/llama-3-8b-instruct:nitro",8192,0.0002,0.0002)},
        { OpenRouterModelIds.MetaLlama370BInstructNitro, new ChatModels("meta-llama/llama-3-70b-instruct:nitro",8192,0.0009,0.0009)},
        { OpenRouterModelIds.Llava13B, new ChatModels("liuhaotian/llava-13b",2048,0.01,0.01)},
        { OpenRouterModelIds.NousHermes2Vision7BAlpha, new ChatModels("nousresearch/nous-hermes-2-vision-7b",4096,0.01,0.01)},
        { OpenRouterModelIds.MistralTiny, new ChatModels("mistralai/mistral-tiny",32000,0.00025,0.00025)},
        { OpenRouterModelIds.MistralSmall, new ChatModels("mistralai/mistral-small",32000,0.002,0.006)},
        { OpenRouterModelIds.MistralMedium, new ChatModels("mistralai/mistral-medium",32000,0.0027,0.0081)},
        { OpenRouterModelIds.MistralLarge, new ChatModels("mistralai/mistral-large",32000,0.008,0.024)},
        { OpenRouterModelIds.CohereCommand, new ChatModels("cohere/command",4096,0.001,0.002)},
        { OpenRouterModelIds.CohereCommandR, new ChatModels("cohere/command-r",128000,0.0005,0.0015)},
        { OpenRouterModelIds.CohereCommandRPlus, new ChatModels("cohere/command-r-plus",128000,0.003,0.015)},

    };

    [CLSCompliant(false)]
    public static ChatModels GetModelById(OpenRouterModelIds modelId)
    {
        if (Models.TryGetValue(modelId, out var id))
        {
            return id;
        }

        throw new ArgumentException($"Invalid Open Router Model {modelId}");
    }

    [CLSCompliant(false)]
    public static ChatModels GetModelById(string modelId)
    {
        var model = Models.Values.FirstOrDefault(s => s.Id == modelId);
        if (model == null)
            throw new KeyNotFoundException($"Model with ID {modelId} not found.");
        return model;
    }
}