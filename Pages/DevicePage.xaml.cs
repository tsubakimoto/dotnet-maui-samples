﻿namespace MauiSamples.Pages;

public partial class DevicePage : ContentPage
{
    public DevicePage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        var deviceInfoText = GetDeviceInfoText();
        DeviceInfoLabel.Text = deviceInfoText;
    }

    private string GetDeviceInfoText()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.AppendLine($"Model: {DeviceInfo.Current.Model}");
        sb.AppendLine($"Manufacturer: {DeviceInfo.Current.Manufacturer}");
        sb.AppendLine($"Name: {DeviceInfo.Name}");
        sb.AppendLine($"OS Version: {DeviceInfo.VersionString}");
        sb.AppendLine($"Refresh Rate: {DeviceInfo.Current}");
        sb.AppendLine($"Idiom: {DeviceInfo.Current.Idiom}");
        sb.AppendLine($"Platform: {DeviceInfo.Current.Platform}");

        bool isVirtual = DeviceInfo.Current.DeviceType switch
        {
            DeviceType.Physical => false,
            DeviceType.Virtual => true,
            _ => false
        };

        sb.AppendLine($"Virtual device? {isVirtual}");

        return sb.ToString();
    }
}