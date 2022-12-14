using System;
using YamlDotNet.Serialization;

namespace Mvk.Launcher.Core;

[Serializable]
public sealed class Options
{
	[YamlMember(Alias = "nickname", Description = "Custom username")]
	public string? UserName { get; set; } = "Player";
	[YamlMember(Alias = "last-selected", Description = "Last selected profile")]
	public string? SelectedProfile { get; set; }
	[YamlMember(Alias = "cache-lifetime", Description = "Cache lifetime (in hours)")]
	public double CacheHoursLifetime { get; set; } = 1; 
	[YamlMember(Alias = "version-caching", Description = "Cache versions list")]
	public bool VersionCaching { get; set; } = true;
	[YamlMember(Alias = "action-after-launch", Description = $"What to do with the window after the game is launched\nBehavior kind: {nameof(AfterLaunchAction.Exit)}|{nameof(AfterLaunchAction.HideWindow)}|{nameof(AfterLaunchAction.Nothing)}")]
	public AfterLaunchAction AfterLaunchAction { get; set; } = default;
	public static readonly Options Default = new();
}
