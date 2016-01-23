using System;
using ObjCRuntime;

[assembly: LinkWith("libTTTAttributedLabel.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, Frameworks = "CoreGraphics CoreText QuartzCore", ForceLoad = true)]
