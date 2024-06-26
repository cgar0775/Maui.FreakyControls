﻿//Make sure .EventArgs is never created as a namespace.
namespace Maui.FreakyControls;

/// <summary>
/// EventArgs for your freaky custom controls
/// </summary>
public class FreakySelectedPinEventArgs : FreakyEventArgs
{
    public string SelectedCharacter { get; set; }
}