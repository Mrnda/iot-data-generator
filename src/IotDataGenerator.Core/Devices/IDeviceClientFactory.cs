﻿using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client;
using TransportType = Microsoft.Azure.Devices.TransportType;

namespace IotDataGenerator.Core.Devices
{
    interface IDeviceClientFactory
    {
        DeviceClient CreateDeviceClient(Device device, TransportType transportType);
    }
}