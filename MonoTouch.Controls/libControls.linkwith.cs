using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libControls.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "QuartzCore", ForceLoad = true)]
