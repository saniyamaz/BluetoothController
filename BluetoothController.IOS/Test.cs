﻿using System;
using CoreBluetooth;
using Foundation;

namespace BluetoothController.IOS
{

	public class Test : CBCentralManagerDelegate
	{
		private CBCentralManager manager;
		private bool scanned = false;
		public Test ()
		{
			manager = new CBCentralManager (this, null);
		}

		public override void DiscoveredPeripheral (CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			Console.WriteLine ("Peripheral: " + peripheral.Identifier.AsString () + " UUID = " + peripheral.UUID + " Name = " + peripheral.Name);
		}

		public override void UpdatedState (CBCentralManager central)
		{
			String s = "";

			//var state = central.State;
			//if (state == CBCentralManagerState.PoweredOn && !scanned) {
			//	Console.WriteLine ("Scanning for devices");
				central.ScanForPeripherals ((CBUUID [])null);
				scanned = true;
			//}

			switch (central.State) {
			case CBCentralManagerState.Unknown:
				s = "Bluetooth is Unknown";
				break;
			case CBCentralManagerState.Resetting:
				s = "Bluetooth is resetting";
				break;
			case CBCentralManagerState.Unsupported:
				s = "Bluetooth is not supported";
				break;
			case CBCentralManagerState.Unauthorized:
				s = "Bluetooth is unauthorized";
				break;
			case CBCentralManagerState.PoweredOff:
				s = "Bluetooth is Off";
				break;
			case CBCentralManagerState.PoweredOn:
				s = "Bluetooth is On";
				break;
			default:
				break;
			}

			Console.WriteLine (s);
		}
	}
}