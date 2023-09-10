/* ***********************************************************
 * This file was automatically generated on 2022-05-11.      *
 *                                                           *
 * C# Bindings Version 2.1.31                                *
 *                                                           *
 * If you have a bugfix for this file and want to commit it, *
 * please fix the bug in the generator. You can find a link  *
 * to the generators git repository on tinkerforge.com       *
 *************************************************************/

using System;

namespace Tinkerforge
{
	/// <summary>
	///  Silently drives one bipolar stepper motor with up to 46V and 1.6A per phase
	/// </summary>
	public class BrickletSilentStepperV2 : Device
	{
		/// <summary>
		///  Used to identify this device type in
		///  <see cref="Tinkerforge.IPConnection.EnumerateCallback"/>.
		/// </summary>
		public static int DEVICE_IDENTIFIER = 2166;

		/// <summary>
		///  The display name of this device.
		/// </summary>
		public static string DEVICE_DISPLAY_NAME = "Silent Stepper Bricklet 2.0";

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_MAX_VELOCITY = 1;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_MAX_VELOCITY = 2;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CURRENT_VELOCITY = 3;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_SPEED_RAMPING = 4;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_SPEED_RAMPING = 5;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_FULL_BRAKE = 6;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_CURRENT_POSITION = 7;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CURRENT_POSITION = 8;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_TARGET_POSITION = 9;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_TARGET_POSITION = 10;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_STEPS = 11;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_STEPS = 12;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_REMAINING_STEPS = 13;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_STEP_CONFIGURATION = 14;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_STEP_CONFIGURATION = 15;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_DRIVE_FORWARD = 16;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_DRIVE_BACKWARD = 17;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_STOP = 18;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_INPUT_VOLTAGE = 19;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_MOTOR_CURRENT = 22;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_MOTOR_CURRENT = 23;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_ENABLED = 24;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_ENABLED = 25;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_BASIC_CONFIGURATION = 26;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_BASIC_CONFIGURATION = 27;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_SPREADCYCLE_CONFIGURATION = 28;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_SPREADCYCLE_CONFIGURATION = 29;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_STEALTH_CONFIGURATION = 30;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_STEALTH_CONFIGURATION = 31;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_COOLSTEP_CONFIGURATION = 32;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_COOLSTEP_CONFIGURATION = 33;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_MISC_CONFIGURATION = 34;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_MISC_CONFIGURATION = 35;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_ERROR_LED_CONFIG = 36;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_ERROR_LED_CONFIG = 37;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_DRIVER_STATUS = 38;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_MINIMUM_VOLTAGE = 39;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_MINIMUM_VOLTAGE = 40;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_TIME_BASE = 43;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_TIME_BASE = 44;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_ALL_DATA = 45;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_ALL_CALLBACK_CONFIGURATION = 46;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_ALL_DATA_CALLBACK_CONFIGURATON = 47;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_GPIO_CONFIGURATION = 48;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_GPIO_CONFIGURATION = 49;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_GPIO_ACTION = 50;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_GPIO_ACTION = 51;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_GPIO_STATE = 52;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_SPITFP_ERROR_COUNT = 234;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_BOOTLOADER_MODE = 235;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_BOOTLOADER_MODE = 236;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_WRITE_FIRMWARE_POINTER = 237;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_WRITE_FIRMWARE = 238;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_STATUS_LED_CONFIG = 239;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_STATUS_LED_CONFIG = 240;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CHIP_TEMPERATURE = 242;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_RESET = 243;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_WRITE_UID = 248;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_READ_UID = 249;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_IDENTITY = 255;

		private const int CALLBACK_UNDER_VOLTAGE = 41;

		private const int CALLBACK_POSITION_REACHED = 42;

		private const int CALLBACK_ALL_DATA = 53;

		private const int CALLBACK_NEW_STATE = 54;

		private const int CALLBACK_GPIO_STATE = 55;


		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_1 = 8;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_2 = 7;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_4 = 6;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_8 = 5;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_16 = 4;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_32 = 3;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_64 = 2;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_128 = 1;

		/// <summary>
		/// </summary>
		public const byte STEP_RESOLUTION_256 = 0;

		/// <summary>
		/// </summary>
		public const byte CHOPPER_MODE_SPREAD_CYCLE = 0;

		/// <summary>
		/// </summary>
		public const byte CHOPPER_MODE_FAST_DECAY = 1;

		/// <summary>
		/// </summary>
		public const byte FREEWHEEL_MODE_NORMAL = 0;

		/// <summary>
		/// </summary>
		public const byte FREEWHEEL_MODE_FREEWHEELING = 1;

		/// <summary>
		/// </summary>
		public const byte FREEWHEEL_MODE_COIL_SHORT_LS = 2;

		/// <summary>
		/// </summary>
		public const byte FREEWHEEL_MODE_COIL_SHORT_HS = 3;

		/// <summary>
		/// </summary>
		public const byte CURRENT_UP_STEP_INCREMENT_1 = 0;

		/// <summary>
		/// </summary>
		public const byte CURRENT_UP_STEP_INCREMENT_2 = 1;

		/// <summary>
		/// </summary>
		public const byte CURRENT_UP_STEP_INCREMENT_4 = 2;

		/// <summary>
		/// </summary>
		public const byte CURRENT_UP_STEP_INCREMENT_8 = 3;

		/// <summary>
		/// </summary>
		public const byte CURRENT_DOWN_STEP_DECREMENT_1 = 0;

		/// <summary>
		/// </summary>
		public const byte CURRENT_DOWN_STEP_DECREMENT_2 = 1;

		/// <summary>
		/// </summary>
		public const byte CURRENT_DOWN_STEP_DECREMENT_8 = 2;

		/// <summary>
		/// </summary>
		public const byte CURRENT_DOWN_STEP_DECREMENT_32 = 3;

		/// <summary>
		/// </summary>
		public const byte MINIMUM_CURRENT_HALF = 0;

		/// <summary>
		/// </summary>
		public const byte MINIMUM_CURRENT_QUARTER = 1;

		/// <summary>
		/// </summary>
		public const byte STALLGUARD_MODE_STANDARD = 0;

		/// <summary>
		/// </summary>
		public const byte STALLGUARD_MODE_FILTERED = 1;

		/// <summary>
		/// </summary>
		public const byte OPEN_LOAD_NONE = 0;

		/// <summary>
		/// </summary>
		public const byte OPEN_LOAD_PHASE_A = 1;

		/// <summary>
		/// </summary>
		public const byte OPEN_LOAD_PHASE_B = 2;

		/// <summary>
		/// </summary>
		public const byte OPEN_LOAD_PHASE_AB = 3;

		/// <summary>
		/// </summary>
		public const byte SHORT_TO_GROUND_NONE = 0;

		/// <summary>
		/// </summary>
		public const byte SHORT_TO_GROUND_PHASE_A = 1;

		/// <summary>
		/// </summary>
		public const byte SHORT_TO_GROUND_PHASE_B = 2;

		/// <summary>
		/// </summary>
		public const byte SHORT_TO_GROUND_PHASE_AB = 3;

		/// <summary>
		/// </summary>
		public const byte OVER_TEMPERATURE_NONE = 0;

		/// <summary>
		/// </summary>
		public const byte OVER_TEMPERATURE_WARNING = 1;

		/// <summary>
		/// </summary>
		public const byte OVER_TEMPERATURE_LIMIT = 2;

		/// <summary>
		/// </summary>
		public const byte STATE_STOP = 1;

		/// <summary>
		/// </summary>
		public const byte STATE_ACCELERATION = 2;

		/// <summary>
		/// </summary>
		public const byte STATE_RUN = 3;

		/// <summary>
		/// </summary>
		public const byte STATE_DEACCELERATION = 4;

		/// <summary>
		/// </summary>
		public const byte STATE_DIRECTION_CHANGE_TO_FORWARD = 5;

		/// <summary>
		/// </summary>
		public const byte STATE_DIRECTION_CHANGE_TO_BACKWARD = 6;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_NONE = 0;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_NORMAL_STOP_RISING_EDGE = 1;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_NORMAL_STOP_FALLING_EDGE = 2;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_FULL_BRAKE_RISING_EDGE = 4;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_FULL_BRAKE_FALLING_EDGE = 8;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_CALLBACK_RISING_EDGE = 16;

		/// <summary>
		/// </summary>
		public const long GPIO_ACTION_CALLBACK_FALLING_EDGE = 32;

		/// <summary>
		/// </summary>
		public const byte ERROR_LED_CONFIG_OFF = 0;

		/// <summary>
		/// </summary>
		public const byte ERROR_LED_CONFIG_ON = 1;

		/// <summary>
		/// </summary>
		public const byte ERROR_LED_CONFIG_SHOW_HEARTBEAT = 2;

		/// <summary>
		/// </summary>
		public const byte ERROR_LED_CONFIG_SHOW_ERROR = 3;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_MODE_BOOTLOADER = 0;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_MODE_FIRMWARE = 1;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_MODE_BOOTLOADER_WAIT_FOR_REBOOT = 2;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_MODE_FIRMWARE_WAIT_FOR_REBOOT = 3;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_MODE_FIRMWARE_WAIT_FOR_ERASE_AND_REBOOT = 4;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_OK = 0;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_INVALID_MODE = 1;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_NO_CHANGE = 2;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_ENTRY_FUNCTION_NOT_PRESENT = 3;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_DEVICE_IDENTIFIER_INCORRECT = 4;

		/// <summary>
		/// </summary>
		public const byte BOOTLOADER_STATUS_CRC_MISMATCH = 5;

		/// <summary>
		/// </summary>
		public const byte STATUS_LED_CONFIG_OFF = 0;

		/// <summary>
		/// </summary>
		public const byte STATUS_LED_CONFIG_ON = 1;

		/// <summary>
		/// </summary>
		public const byte STATUS_LED_CONFIG_SHOW_HEARTBEAT = 2;

		/// <summary>
		/// </summary>
		public const byte STATUS_LED_CONFIG_SHOW_STATUS = 3;


		/// <summary>
		///  This callback is triggered when the input voltage drops below the value set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetMinimumVoltage"/>. The parameter is the current voltage.
		/// </summary>
		public event UnderVoltageEventHandler UnderVoltageCallback;
		/// <summary>
		/// </summary>
		public delegate void UnderVoltageEventHandler(BrickletSilentStepperV2 sender, int voltage);

		/// <summary>
		///  This callback is triggered when a position set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/> or
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/> is reached.
		///  
		///  <note>
		///   Since we can't get any feedback from the stepper motor, this only works if the
		///   acceleration (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/>) is set smaller or equal to the
		///   maximum acceleration of the motor. Otherwise the motor will lag behind the
		///   control value and the callback will be triggered too early.
		///  </note>
		/// </summary>
		public event PositionReachedEventHandler PositionReachedCallback;
		/// <summary>
		/// </summary>
		public delegate void PositionReachedEventHandler(BrickletSilentStepperV2 sender, int position);

		/// <summary>
		///  This callback is triggered periodically with the period that is set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetAllCallbackConfiguration"/>. The parameters are: the current velocity,
		///  the current position, the remaining steps, the stack voltage, the external
		///  voltage and the current consumption of the stepper motor.
		/// </summary>
		public event AllDataEventHandler AllDataCallback;
		/// <summary>
		/// </summary>
		public delegate void AllDataEventHandler(BrickletSilentStepperV2 sender, int currentVelocity, int currentPosition, int remainingSteps, int inputVoltage, int currentConsumption);

		/// <summary>
		///  This callback is triggered whenever the Silent Stepper Bricklet 2.0 enters a new state.
		///  It returns the new state as well as the previous state.
		/// </summary>
		public event NewStateEventHandler NewStateCallback;
		/// <summary>
		/// </summary>
		public delegate void NewStateEventHandler(BrickletSilentStepperV2 sender, byte stateNew, byte statePrevious);

		/// <summary>
		///  This callback is triggered by GPIO changes if it is activated through <see cref="Tinkerforge.BrickletSilentStepperV2.SetGPIOAction"/>.
		/// </summary>
		public event GPIOStateEventHandler GPIOStateCallback;
		/// <summary>
		/// </summary>
		public delegate void GPIOStateEventHandler(BrickletSilentStepperV2 sender, bool[] gpioState);

		/// <summary>
		///  Creates an object with the unique device ID <c>uid</c> and adds  it to
		///  the IPConnection <c>ipcon</c>.
		/// </summary>
		public BrickletSilentStepperV2(string uid, IPConnection ipcon) : base(uid, ipcon, DEVICE_IDENTIFIER, DEVICE_DISPLAY_NAME)
		{
			apiVersion[0] = 2;
			apiVersion[1] = 0;
			apiVersion[2] = 0;

			callbackWrappers[CALLBACK_UNDER_VOLTAGE] = new CallbackWrapper(OnUnderVoltageCallback);
			callbackWrappers[CALLBACK_POSITION_REACHED] = new CallbackWrapper(OnPositionReachedCallback);
			callbackWrappers[CALLBACK_ALL_DATA] = new CallbackWrapper(OnAllDataCallback);
			callbackWrappers[CALLBACK_NEW_STATE] = new CallbackWrapper(OnNewStateCallback);
			callbackWrappers[CALLBACK_GPIO_STATE] = new CallbackWrapper(OnGPIOStateCallback);


			responseExpected[FUNCTION_SET_MAX_VELOCITY] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_MAX_VELOCITY] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_CURRENT_VELOCITY] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_SPEED_RAMPING] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_SPEED_RAMPING] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_FULL_BRAKE] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_SET_CURRENT_POSITION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_CURRENT_POSITION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_TARGET_POSITION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_TARGET_POSITION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_STEPS] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_STEPS] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_REMAINING_STEPS] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_STEP_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_STEP_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_DRIVE_FORWARD] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_DRIVE_BACKWARD] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_STOP] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_INPUT_VOLTAGE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_MOTOR_CURRENT] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_MOTOR_CURRENT] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_ENABLED] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_ENABLED] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_BASIC_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_BASIC_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_SPREADCYCLE_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_SPREADCYCLE_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_STEALTH_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_STEALTH_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_COOLSTEP_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_COOLSTEP_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_MISC_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_MISC_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_ERROR_LED_CONFIG] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_ERROR_LED_CONFIG] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_DRIVER_STATUS] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_MINIMUM_VOLTAGE] = ResponseExpectedFlag.TRUE;
			responseExpected[FUNCTION_GET_MINIMUM_VOLTAGE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_TIME_BASE] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_TIME_BASE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_ALL_DATA] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_ALL_CALLBACK_CONFIGURATION] = ResponseExpectedFlag.TRUE;
			responseExpected[FUNCTION_GET_ALL_DATA_CALLBACK_CONFIGURATON] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_GPIO_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_GPIO_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_GPIO_ACTION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_GPIO_ACTION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_GPIO_STATE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_SPITFP_ERROR_COUNT] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_BOOTLOADER_MODE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_BOOTLOADER_MODE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_WRITE_FIRMWARE_POINTER] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_WRITE_FIRMWARE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_STATUS_LED_CONFIG] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_STATUS_LED_CONFIG] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_CHIP_TEMPERATURE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_RESET] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_WRITE_UID] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_READ_UID] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_IDENTITY] = ResponseExpectedFlag.ALWAYS_TRUE;

			ipcon.AddDevice(this);
		}

		/// <summary>
		///  Sets the maximum velocity of the stepper motor.
		///  This function does *not* start the motor, it merely sets the maximum
		///  velocity the stepper motor is accelerated to. To get the motor running use
		///  either <see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/>, <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/>, <see cref="Tinkerforge.BrickletSilentStepperV2.DriveForward"/> or
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.DriveBackward"/>.
		/// </summary>
		public void SetMaxVelocity(int velocity)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_SET_MAX_VELOCITY);
			LEConverter.To((short)velocity, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the velocity as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMaxVelocity"/>.
		/// </summary>
		public int GetMaxVelocity()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_MAX_VELOCITY);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Returns the *current* velocity of the stepper motor.
		/// </summary>
		public int GetCurrentVelocity()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_CURRENT_VELOCITY);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets the acceleration and deacceleration of the stepper motor.
		///  An acceleration of 1000 means, that
		///  every second the velocity is increased by 1000 *steps/s*.
		///  
		///  For example: If the current velocity is 0 and you want to accelerate to a
		///  velocity of 8000 *steps/s* in 10 seconds, you should set an acceleration
		///  of 800 *steps/s²*.
		///  
		///  An acceleration/deacceleration of 0 means instantaneous
		///  acceleration/deacceleration (not recommended)
		/// </summary>
		public void SetSpeedRamping(int acceleration, int deacceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_SPEED_RAMPING);
			LEConverter.To((short)acceleration, 8, request);
			LEConverter.To((short)deacceleration, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the acceleration and deacceleration as set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/>.
		/// </summary>
		public void GetSpeedRamping(out int acceleration, out int deacceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_SPEED_RAMPING);

			byte[] response = SendRequest(request, 12);

			acceleration = LEConverter.UShortFrom(8, response);
			deacceleration = LEConverter.UShortFrom(10, response);
		}

		/// <summary>
		///  Executes an active full brake.
		///  
		///  <note type="caution">
		///   This function is for emergency purposes,
		///   where an immediate brake is necessary. Depending on the current velocity and
		///   the strength of the motor, a full brake can be quite violent.
		///  </note>
		///  
		///  Call <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> if you just want to stop the motor.
		/// </summary>
		public void FullBrake()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_FULL_BRAKE);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Sets the current steps of the internal step counter. This can be used to
		///  set the current position to 0 when some kind of starting position
		///  is reached (e.g. when a CNC machine reaches a corner).
		/// </summary>
		public void SetCurrentPosition(int position)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_CURRENT_POSITION);
			LEConverter.To((int)position, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the current position of the stepper motor in steps. On startup
		///  the position is 0. The steps are counted with all possible driving
		///  functions (<see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/>, <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/>, <see cref="Tinkerforge.BrickletSilentStepperV2.DriveForward"/> or
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.DriveBackward"/>). It also is possible to reset the steps to 0 or
		///  set them to any other desired value with <see cref="Tinkerforge.BrickletSilentStepperV2.SetCurrentPosition"/>.
		/// </summary>
		public int GetCurrentPosition()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_CURRENT_POSITION);

			byte[] response = SendRequest(request, 12);

			return LEConverter.IntFrom(8, response);
		}

		/// <summary>
		///  Sets the target position of the stepper motor in steps. For example,
		///  if the current position of the motor is 500 and <see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/> is
		///  called with 1000, the stepper motor will drive 500 steps forward. It will
		///  use the velocity, acceleration and deacceleration as set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetMaxVelocity"/> and <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/>.
		///  
		///  A call of <see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/> with the parameter *x* is equivalent to
		///  a call of <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/> with the parameter
		///  (*x* - <see cref="Tinkerforge.BrickletSilentStepperV2.GetCurrentPosition"/>).
		/// </summary>
		public void SetTargetPosition(int position)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_TARGET_POSITION);
			LEConverter.To((int)position, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the last target position as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetTargetPosition"/>.
		/// </summary>
		public int GetTargetPosition()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_TARGET_POSITION);

			byte[] response = SendRequest(request, 12);

			return LEConverter.IntFrom(8, response);
		}

		/// <summary>
		///  Sets the number of steps the stepper motor should run. Positive values
		///  will drive the motor forward and negative values backward.
		///  The velocity, acceleration and deacceleration as set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetMaxVelocity"/> and <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/> will be used.
		/// </summary>
		public void SetSteps(int steps)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_STEPS);
			LEConverter.To((int)steps, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the last steps as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/>.
		/// </summary>
		public int GetSteps()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_STEPS);

			byte[] response = SendRequest(request, 12);

			return LEConverter.IntFrom(8, response);
		}

		/// <summary>
		///  Returns the remaining steps of the last call of <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/>.
		///  For example, if <see cref="Tinkerforge.BrickletSilentStepperV2.SetSteps"/> is called with 2000 and
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.GetRemainingSteps"/> is called after the motor has run for 500 steps,
		///  it will return 1500.
		/// </summary>
		public int GetRemainingSteps()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_REMAINING_STEPS);

			byte[] response = SendRequest(request, 12);

			return LEConverter.IntFrom(8, response);
		}

		/// <summary>
		///  Sets the step resolution from full-step up to 1/256-step.
		///  
		///  If interpolation is turned on, the Silent Stepper Bricklet 2.0 will always interpolate
		///  your step inputs as 1/256-step. If you use full-step mode with interpolation, each
		///  step will generate 256 1/256 steps.
		///  
		///  For maximum torque use full-step without interpolation. For maximum resolution use
		///  1/256-step. Turn interpolation on to make the Stepper driving less noisy.
		///  
		///  If you often change the speed with high acceleration you should turn the
		///  interpolation off.
		/// </summary>
		public void SetStepConfiguration(byte stepResolution, bool interpolation)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_SET_STEP_CONFIGURATION);
			LEConverter.To((byte)stepResolution, 8, request);
			LEConverter.To((bool)interpolation, 9, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the step mode as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetStepConfiguration"/>.
		/// </summary>
		public void GetStepConfiguration(out byte stepResolution, out bool interpolation)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_STEP_CONFIGURATION);

			byte[] response = SendRequest(request, 10);

			stepResolution = LEConverter.ByteFrom(8, response);
			interpolation = LEConverter.BoolFrom(9, response);
		}

		/// <summary>
		///  Drives the stepper motor forward until <see cref="Tinkerforge.BrickletSilentStepperV2.DriveBackward"/> or
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> is called. The velocity, acceleration and deacceleration as
		///  set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMaxVelocity"/> and <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/> will be used.
		/// </summary>
		public void DriveForward()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_DRIVE_FORWARD);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Drives the stepper motor backward until <see cref="Tinkerforge.BrickletSilentStepperV2.DriveForward"/> or
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> is triggered. The velocity, acceleration and deacceleration as
		///  set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMaxVelocity"/> and <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/> will be used.
		/// </summary>
		public void DriveBackward()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_DRIVE_BACKWARD);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Stops the stepper motor with the deacceleration as set by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetSpeedRamping"/>.
		/// </summary>
		public void Stop()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_STOP);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the external input voltage. The external input voltage is
		///  given via the black power input connector on the Silent Stepper Bricklet 2.0.
		///  
		///  If there is an external input voltage and a stack input voltage, the motor
		///  will be driven by the external input voltage. If there is only a stack
		///  voltage present, the motor will be driven by this voltage.
		///  
		///  <note type="caution">
		///   This means, if you have a high stack voltage and a low external voltage,
		///   the motor will be driven with the low external voltage. If you then remove
		///   the external connection, it will immediately be driven by the high
		///   stack voltage
		///  </note>
		/// </summary>
		public int GetInputVoltage()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_INPUT_VOLTAGE);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets the current with which the motor will be driven.
		///  
		///  <note type="caution">
		///   Do not set this value above the specifications of your stepper motor.
		///   Otherwise it may damage your motor.
		///  </note>
		/// </summary>
		public void SetMotorCurrent(int current)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_SET_MOTOR_CURRENT);
			LEConverter.To((short)current, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the current as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMotorCurrent"/>.
		/// </summary>
		public int GetMotorCurrent()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_MOTOR_CURRENT);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Enables/Disables the driver chip. The driver parameters can be configured (maximum velocity,
		///  acceleration, etc) before it is enabled.
		///  
		///  <note type="caution">
		///   Disabling the driver chip while the motor is still turning can damage the
		///   driver chip. The motor should be stopped calling <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> function
		///   before disabling the motor power. The <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> function will **not**
		///   wait until the motor is actually stopped. You have to explicitly wait for the
		///   appropriate time after calling the <see cref="Tinkerforge.BrickletSilentStepperV2.Stop"/> function before calling
		///   the <see cref="Tinkerforge.BrickletSilentStepperV2.SetEnabled"/> with false function.
		///  </note>
		/// </summary>
		public void SetEnabled(bool enabled)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_SET_ENABLED);
			LEConverter.To((bool)enabled, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns *true* if the stepper driver is enabled, *false* otherwise.
		/// </summary>
		public bool GetEnabled()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_ENABLED);

			byte[] response = SendRequest(request, 9);

			return LEConverter.BoolFrom(8, response);
		}

		/// <summary>
		///  Sets the basic configuration parameters for the different modes (Stealth, Coolstep, Classic).
		///  
		///  * Standstill Current: This value can be used to lower the current during stand still. This might
		///    be reasonable to reduce the heating of the motor and the Bricklet 2.0. When the motor is in standstill
		///    the configured motor phase current will be driven until the configured
		///    Power Down Time is elapsed. After that the phase current will be reduced to the standstill
		///    current. The elapsed time for this reduction can be configured with the Standstill Delay Time.
		///    The maximum allowed value is the configured maximum motor current
		///    (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetMotorCurrent"/>).
		///  
		///  * Motor Run Current: The value sets the motor current when the motor is running.
		///    Use a value of at least one half of the global maximum motor current for a good
		///    microstep performance. The maximum allowed value is the current
		///    motor current. The API maps the entered value to 1/32 ... 32/32 of the maximum
		///    motor current. This value should be used to change the motor current during motor movement,
		///    whereas the global maximum motor current should not be changed while the motor is moving
		///    (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetMotorCurrent"/>).
		///  
		///  * Standstill Delay Time: Controls the duration for motor power down after a motion
		///    as soon as standstill is detected and the Power Down Time is expired. A high Standstill Delay
		///    Time results in a smooth transition that avoids motor jerk during power down.
		///  
		///  * Power Down Time: Sets the delay time after a stand still.
		///  
		///  * Stealth Threshold: Sets the upper threshold for Stealth mode.
		///    If the velocity of the motor goes above this value, Stealth mode is turned
		///    off. Otherwise it is turned on. In Stealth mode the torque declines with high speed.
		///  
		///  * Coolstep Threshold: Sets the lower threshold for Coolstep mode.
		///    The Coolstep Threshold needs to be above the Stealth Threshold.
		///  
		///  * Classic Threshold: Sets the lower threshold for classic mode.
		///    In classic mode the stepper becomes more noisy, but the torque is maximized.
		///  
		///  * High Velocity Chopper Mode: If High Velocity Chopper Mode is enabled, the stepper control
		///    is optimized to run the stepper motors at high velocities.
		///  
		///  If you want to use all three thresholds make sure that
		///  Stealth Threshold &lt; Coolstep Threshold &lt; Classic Threshold.
		/// </summary>
		public void SetBasicConfiguration(int standstillCurrent, int motorRunCurrent, int standstillDelayTime, int powerDownTime, int stealthThreshold, int coolstepThreshold, int classicThreshold, bool highVelocityChopperMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(23, FUNCTION_SET_BASIC_CONFIGURATION);
			LEConverter.To((short)standstillCurrent, 8, request);
			LEConverter.To((short)motorRunCurrent, 10, request);
			LEConverter.To((short)standstillDelayTime, 12, request);
			LEConverter.To((short)powerDownTime, 14, request);
			LEConverter.To((short)stealthThreshold, 16, request);
			LEConverter.To((short)coolstepThreshold, 18, request);
			LEConverter.To((short)classicThreshold, 20, request);
			LEConverter.To((bool)highVelocityChopperMode, 22, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>.
		/// </summary>
		public void GetBasicConfiguration(out int standstillCurrent, out int motorRunCurrent, out int standstillDelayTime, out int powerDownTime, out int stealthThreshold, out int coolstepThreshold, out int classicThreshold, out bool highVelocityChopperMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_BASIC_CONFIGURATION);

			byte[] response = SendRequest(request, 23);

			standstillCurrent = LEConverter.UShortFrom(8, response);
			motorRunCurrent = LEConverter.UShortFrom(10, response);
			standstillDelayTime = LEConverter.UShortFrom(12, response);
			powerDownTime = LEConverter.UShortFrom(14, response);
			stealthThreshold = LEConverter.UShortFrom(16, response);
			coolstepThreshold = LEConverter.UShortFrom(18, response);
			classicThreshold = LEConverter.UShortFrom(20, response);
			highVelocityChopperMode = LEConverter.BoolFrom(22, response);
		}

		/// <summary>
		///  Note: If you don't know what any of this means you can very likely keep all of
		///  the values as default!
		///  
		///  Sets the Spreadcycle configuration parameters. Spreadcycle is a chopper algorithm which actively
		///  controls the motor current flow. More information can be found in the TMC2130 datasheet on page
		///  47 (7 spreadCycle and Classic Chopper).
		///  
		///  * Slow Decay Duration: Controls duration of off time setting of slow decay phase.
		///    0 = driver disabled, all bridges off. Use 1 only with Comparator Blank time &gt;= 2.
		///  
		///  * Enable Random Slow Decay: Set to false to fix chopper off time as set by Slow Decay Duration.
		///    If you set it to true, Decay Duration is randomly modulated.
		///  
		///  * Fast Decay Duration: Sets the fast decay duration. This parameters is
		///    only used if the Chopper Mode is set to Fast Decay.
		///  
		///  * Hysteresis Start Value: Sets the hysteresis start value. This parameter is
		///    only used if the Chopper Mode is set to Spread Cycle.
		///  
		///  * Hysteresis End Value: Sets the hysteresis end value. This parameter is
		///    only used if the Chopper Mode is set to Spread Cycle.
		///  
		///  * Sine Wave Offset: Sets the sine wave offset. This parameters is
		///    only used if the Chopper Mode is set to Fast Decay. 1/512 of the value becomes added to the absolute
		///    value of the sine wave.
		///  
		///  * Chopper Mode: 0 = Spread Cycle, 1 = Fast Decay.
		///  
		///  * Comparator Blank Time: Sets the blank time of the comparator. Available values are
		///  
		///    * 0 = 16 clocks,
		///    * 1 = 24 clocks,
		///    * 2 = 36 clocks and
		///    * 3 = 54 clocks.
		///  
		///    A value of 1 or 2 is recommended for most applications.
		///  
		///  * Fast Decay Without Comparator: If set to true the current comparator usage for termination of the
		///    fast decay cycle is disabled.
		/// </summary>
		public void SetSpreadcycleConfiguration(byte slowDecayDuration, bool enableRandomSlowDecay, byte fastDecayDuration, byte hysteresisStartValue, short hysteresisEndValue, short sineWaveOffset, byte chopperMode, byte comparatorBlankTime, bool fastDecayWithoutComparator)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(17, FUNCTION_SET_SPREADCYCLE_CONFIGURATION);
			LEConverter.To((byte)slowDecayDuration, 8, request);
			LEConverter.To((bool)enableRandomSlowDecay, 9, request);
			LEConverter.To((byte)fastDecayDuration, 10, request);
			LEConverter.To((byte)hysteresisStartValue, 11, request);
			LEConverter.To((byte)hysteresisEndValue, 12, request);
			LEConverter.To((byte)sineWaveOffset, 13, request);
			LEConverter.To((byte)chopperMode, 14, request);
			LEConverter.To((byte)comparatorBlankTime, 15, request);
			LEConverter.To((bool)fastDecayWithoutComparator, 16, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>.
		/// </summary>
		public void GetSpreadcycleConfiguration(out byte slowDecayDuration, out bool enableRandomSlowDecay, out byte fastDecayDuration, out byte hysteresisStartValue, out short hysteresisEndValue, out short sineWaveOffset, out byte chopperMode, out byte comparatorBlankTime, out bool fastDecayWithoutComparator)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_SPREADCYCLE_CONFIGURATION);

			byte[] response = SendRequest(request, 17);

			slowDecayDuration = LEConverter.ByteFrom(8, response);
			enableRandomSlowDecay = LEConverter.BoolFrom(9, response);
			fastDecayDuration = LEConverter.ByteFrom(10, response);
			hysteresisStartValue = LEConverter.ByteFrom(11, response);
			hysteresisEndValue = LEConverter.SByteFrom(12, response);
			sineWaveOffset = LEConverter.SByteFrom(13, response);
			chopperMode = LEConverter.ByteFrom(14, response);
			comparatorBlankTime = LEConverter.ByteFrom(15, response);
			fastDecayWithoutComparator = LEConverter.BoolFrom(16, response);
		}

		/// <summary>
		///  Note: If you don't know what any of this means you can very likely keep all of
		///  the values as default!
		///  
		///  Sets the configuration relevant for Stealth mode.
		///  
		///  * Enable Stealth: If set to true the stealth mode is enabled, if set to false the
		///    stealth mode is disabled, even if the speed is below the threshold set in <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>.
		///  
		///  * Amplitude: If autoscale is disabled, the PWM amplitude is scaled by this value. If autoscale is enabled,
		///    this value defines the maximum PWM amplitude change per half wave.
		///  
		///  * Gradient: If autoscale is disabled, the PWM gradient is scaled by this value. If autoscale is enabled,
		///    this value defines the maximum PWM gradient. With autoscale a value above 64 is recommended,
		///    otherwise the regulation might not be able to measure the current.
		///  
		///  * Enable Autoscale: If set to true, automatic current control is used. Otherwise the user defined
		///    amplitude and gradient are used.
		///  
		///  * Force Symmetric: If true, A symmetric PWM cycle is enforced. Otherwise the PWM value may change within each
		///    PWM cycle.
		///  
		///  * Freewheel Mode: The freewheel mode defines the behavior in stand still if the Standstill Current
		///    (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>) is set to 0.
		/// </summary>
		public void SetStealthConfiguration(bool enableStealth, byte amplitude, byte gradient, bool enableAutoscale, bool forceSymmetric, byte freewheelMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(14, FUNCTION_SET_STEALTH_CONFIGURATION);
			LEConverter.To((bool)enableStealth, 8, request);
			LEConverter.To((byte)amplitude, 9, request);
			LEConverter.To((byte)gradient, 10, request);
			LEConverter.To((bool)enableAutoscale, 11, request);
			LEConverter.To((bool)forceSymmetric, 12, request);
			LEConverter.To((byte)freewheelMode, 13, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetStealthConfiguration"/>.
		/// </summary>
		public void GetStealthConfiguration(out bool enableStealth, out byte amplitude, out byte gradient, out bool enableAutoscale, out bool forceSymmetric, out byte freewheelMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_STEALTH_CONFIGURATION);

			byte[] response = SendRequest(request, 14);

			enableStealth = LEConverter.BoolFrom(8, response);
			amplitude = LEConverter.ByteFrom(9, response);
			gradient = LEConverter.ByteFrom(10, response);
			enableAutoscale = LEConverter.BoolFrom(11, response);
			forceSymmetric = LEConverter.BoolFrom(12, response);
			freewheelMode = LEConverter.ByteFrom(13, response);
		}

		/// <summary>
		///  Note: If you don't know what any of this means you can very likely keep all of
		///  the values as default!
		///  
		///  Sets the configuration relevant for Coolstep.
		///  
		///  * Minimum Stallguard Value: If the Stallguard result falls below this value*32, the motor current
		///    is increased to reduce motor load angle. A value of 0 turns Coolstep off.
		///  
		///  * Maximum Stallguard Value: If the Stallguard result goes above
		///    (Min Stallguard Value + Max Stallguard Value + 1) * 32, the motor current is decreased to save
		///    energy.
		///  
		///  * Current Up Step Width: Sets the up step increment per Stallguard value. The value range is 0-3,
		///    corresponding to the increments 1, 2, 4 and 8.
		///  
		///  * Current Down Step Width: Sets the down step decrement per Stallguard value. The value range is 0-3,
		///    corresponding to the decrements 1, 2, 8 and 16.
		///  
		///  * Minimum Current: Sets the minimum current for Coolstep current control. You can choose between
		///    half and quarter of the run current.
		///  
		///  * Stallguard Threshold Value: Sets the level for stall output (see <see cref="Tinkerforge.BrickletSilentStepperV2.GetDriverStatus"/>).
		///    A lower value gives a higher sensitivity. You have to find a suitable value for your
		///    motor by trial and error, 0 works for most motors.
		///  
		///  * Stallguard Mode: Set to 0 for standard resolution or 1 for filtered mode. In filtered mode the Stallguard
		///    signal will be updated every four full-steps.
		/// </summary>
		public void SetCoolstepConfiguration(byte minimumStallguardValue, byte maximumStallguardValue, byte currentUpStepWidth, byte currentDownStepWidth, byte minimumCurrent, short stallguardThresholdValue, byte stallguardMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(15, FUNCTION_SET_COOLSTEP_CONFIGURATION);
			LEConverter.To((byte)minimumStallguardValue, 8, request);
			LEConverter.To((byte)maximumStallguardValue, 9, request);
			LEConverter.To((byte)currentUpStepWidth, 10, request);
			LEConverter.To((byte)currentDownStepWidth, 11, request);
			LEConverter.To((byte)minimumCurrent, 12, request);
			LEConverter.To((byte)stallguardThresholdValue, 13, request);
			LEConverter.To((byte)stallguardMode, 14, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetCoolstepConfiguration"/>.
		/// </summary>
		public void GetCoolstepConfiguration(out byte minimumStallguardValue, out byte maximumStallguardValue, out byte currentUpStepWidth, out byte currentDownStepWidth, out byte minimumCurrent, out short stallguardThresholdValue, out byte stallguardMode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_COOLSTEP_CONFIGURATION);

			byte[] response = SendRequest(request, 15);

			minimumStallguardValue = LEConverter.ByteFrom(8, response);
			maximumStallguardValue = LEConverter.ByteFrom(9, response);
			currentUpStepWidth = LEConverter.ByteFrom(10, response);
			currentDownStepWidth = LEConverter.ByteFrom(11, response);
			minimumCurrent = LEConverter.ByteFrom(12, response);
			stallguardThresholdValue = LEConverter.SByteFrom(13, response);
			stallguardMode = LEConverter.ByteFrom(14, response);
		}

		/// <summary>
		///  Note: If you don't know what any of this means you can very likely keep all of
		///  the values as default!
		///  
		///  Sets miscellaneous configuration parameters.
		///  
		///  * Disable Short To Ground Protection: Set to false to enable short to ground protection, otherwise
		///    it is disabled.
		///  
		///  * Synchronize Phase Frequency: With this parameter you can synchronize the chopper for both phases
		///    of a two phase motor to avoid the occurrence of a beat. The value range is 0-15. If set to 0,
		///    the synchronization is turned off. Otherwise the synchronization is done through the formula
		///    f_sync = f_clk/(value*64). In Classic Mode the synchronization is automatically switched off.
		///    f_clk is 12.8MHz.
		/// </summary>
		public void SetMiscConfiguration(bool disableShortToGroundProtection, byte synchronizePhaseFrequency)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_SET_MISC_CONFIGURATION);
			LEConverter.To((bool)disableShortToGroundProtection, 8, request);
			LEConverter.To((byte)synchronizePhaseFrequency, 9, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMiscConfiguration"/>.
		/// </summary>
		public void GetMiscConfiguration(out bool disableShortToGroundProtection, out byte synchronizePhaseFrequency)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_MISC_CONFIGURATION);

			byte[] response = SendRequest(request, 10);

			disableShortToGroundProtection = LEConverter.BoolFrom(8, response);
			synchronizePhaseFrequency = LEConverter.ByteFrom(9, response);
		}

		/// <summary>
		///  Configures the error LED to be either turned off, turned on, blink in
		///  heartbeat mode or show an error.
		///  
		///  If the LED is configured to show errors it has three different states:
		///  
		///  * Off: No error present.
		///  * 250ms interval blink: Overtemperature warning.
		///  * 1s interval blink: Input voltage too small.
		///  * full red: motor disabled because of short to ground in phase a or b or because of overtemperature.
		/// </summary>
		public void SetErrorLEDConfig(byte config)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_SET_ERROR_LED_CONFIG);
			LEConverter.To((byte)config, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the LED configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetErrorLEDConfig"/>
		/// </summary>
		public byte GetErrorLEDConfig()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_ERROR_LED_CONFIG);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Returns the current driver status.
		///  
		///  * Open Load: Indicates if an open load is present on phase A, B or both. This could mean that there is a problem
		///    with the wiring of the motor. False detection can occur in fast motion as well as during stand still.
		///  
		///  * Short To Ground: Indicates if a short to ground is present on phase A, B or both. If this is detected the driver
		///    automatically becomes disabled and stays disabled until it is enabled again manually.
		///  
		///  * Over Temperature: The over temperature indicator switches to "Warning" if the driver IC warms up. The warning flag
		///    is expected during long duration stepper uses. If the temperature limit is reached the indicator switches
		///    to "Limit". In this case the driver becomes disabled until it cools down again.
		///  
		///  * Motor Stalled: Is true if a motor stall was detected.
		///  
		///  * Actual Motor Current: Indicates the actual current control scaling as used in Coolstep mode.
		///    It represents a multiplier of 1/32 to 32/32 of the
		///    ``Motor Run Current`` as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>. Example: If a ``Motor Run Current``
		///    of 1000mA was set and the returned value is 15, the ``Actual Motor Current`` is 16/32*1000mA = 500mA.
		///  
		///  * Stallguard Result: Indicates the load of the motor. A lower value signals a higher load. Per trial and error
		///    you can find out which value corresponds to a suitable torque for the velocity used in your application.
		///    After that you can use this threshold value to find out if a motor stall becomes probable and react on it (e.g.
		///    decrease velocity).
		///    During stand still this value can not be used for stall detection, it shows the chopper on-time for motor coil A.
		///  
		///  * Stealth Voltage Amplitude: Shows the actual PWM scaling. In Stealth mode it can be used to detect motor load and
		///    stall if autoscale is enabled (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetStealthConfiguration"/>).
		/// </summary>
		public void GetDriverStatus(out byte openLoad, out byte shortToGround, out byte overTemperature, out bool motorStalled, out byte actualMotorCurrent, out bool fullStepActive, out byte stallguardResult, out byte stealthVoltageAmplitude)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_DRIVER_STATUS);

			byte[] response = SendRequest(request, 16);

			openLoad = LEConverter.ByteFrom(8, response);
			shortToGround = LEConverter.ByteFrom(9, response);
			overTemperature = LEConverter.ByteFrom(10, response);
			motorStalled = LEConverter.BoolFrom(11, response);
			actualMotorCurrent = LEConverter.ByteFrom(12, response);
			fullStepActive = LEConverter.BoolFrom(13, response);
			stallguardResult = LEConverter.ByteFrom(14, response);
			stealthVoltageAmplitude = LEConverter.ByteFrom(15, response);
		}

		/// <summary>
		///  Sets the minimum voltage, below which the <see cref="Tinkerforge.BrickletSilentStepperV2.UnderVoltageCallback"/> callback
		///  is triggered. The minimum possible value that works with the Silent Stepper
		///  Bricklet 2.0 is 8V.
		///  You can use this function to detect the discharge of a battery that is used
		///  to drive the stepper motor. If you have a fixed power supply, you likely do
		///  not need this functionality.
		/// </summary>
		public void SetMinimumVoltage(int voltage)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_SET_MINIMUM_VOLTAGE);
			LEConverter.To((short)voltage, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the minimum voltage as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetMinimumVoltage"/>.
		/// </summary>
		public int GetMinimumVoltage()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_MINIMUM_VOLTAGE);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets the time base of the velocity and the acceleration of the Silent Stepper
		///  Bricklet 2.0.
		///  
		///  For example, if you want to make one step every 1.5 seconds, you can set
		///  the time base to 15 and the velocity to 10. Now the velocity is
		///  10steps/15s = 1steps/1.5s.
		/// </summary>
		public void SetTimeBase(long timeBase)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_TIME_BASE);
			LEConverter.To((int)timeBase, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the time base as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetTimeBase"/>.
		/// </summary>
		public long GetTimeBase()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_TIME_BASE);

			byte[] response = SendRequest(request, 12);

			return LEConverter.UIntFrom(8, response);
		}

		/// <summary>
		///  Returns the following parameters: The current velocity,
		///  the current position, the remaining steps, the stack voltage, the external
		///  voltage and the current consumption of the stepper motor.
		///  
		///  The current consumption is calculated by multiplying the ``Actual Motor Current``
		///  value (see <see cref="Tinkerforge.BrickletSilentStepperV2.SetBasicConfiguration"/>) with the ``Motor Run Current``
		///  (see <see cref="Tinkerforge.BrickletSilentStepperV2.GetDriverStatus"/>). This is an internal calculation of the
		///  driver, not an independent external measurement.
		///  
		///  The current consumption calculation was broken up to firmware 2.0.1, it is fixed
		///  since firmware 2.0.2.
		///  
		///  There is also a callback for this function, see <see cref="Tinkerforge.BrickletSilentStepperV2.AllDataCallback"/> callback.
		/// </summary>
		public void GetAllData(out int currentVelocity, out int currentPosition, out int remainingSteps, out int inputVoltage, out int currentConsumption)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_ALL_DATA);

			byte[] response = SendRequest(request, 22);

			currentVelocity = LEConverter.UShortFrom(8, response);
			currentPosition = LEConverter.IntFrom(10, response);
			remainingSteps = LEConverter.IntFrom(14, response);
			inputVoltage = LEConverter.UShortFrom(18, response);
			currentConsumption = LEConverter.UShortFrom(20, response);
		}

		/// <summary>
		///  Sets the period with which the <see cref="Tinkerforge.BrickletSilentStepperV2.AllDataCallback"/> callback is triggered
		///  periodically. A value of 0 turns the callback off.
		/// </summary>
		public void SetAllCallbackConfiguration(long period)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_ALL_CALLBACK_CONFIGURATION);
			LEConverter.To((int)period, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the period as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetAllCallbackConfiguration"/>.
		/// </summary>
		public long GetAllDataCallbackConfiguraton()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_ALL_DATA_CALLBACK_CONFIGURATON);

			byte[] response = SendRequest(request, 12);

			return LEConverter.UIntFrom(8, response);
		}

		/// <summary>
		///  Sets the GPIO configuration for the given channel.
		///  You can configure a debounce and the deceleration that is used if the action is
		///  configured as ``normal stop``. See <see cref="Tinkerforge.BrickletSilentStepperV2.SetGPIOAction"/>.
		/// </summary>
		public void SetGPIOConfiguration(byte channel, int debounce, int stopDeceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(13, FUNCTION_SET_GPIO_CONFIGURATION);
			LEConverter.To((byte)channel, 8, request);
			LEConverter.To((short)debounce, 9, request);
			LEConverter.To((short)stopDeceleration, 11, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the GPIO configuration for a channel as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetGPIOConfiguration"/>.
		/// </summary>
		public void GetGPIOConfiguration(byte channel, out int debounce, out int stopDeceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_GET_GPIO_CONFIGURATION);
			LEConverter.To((byte)channel, 8, request);

			byte[] response = SendRequest(request, 12);

			debounce = LEConverter.UShortFrom(8, response);
			stopDeceleration = LEConverter.UShortFrom(10, response);
		}

		/// <summary>
		///  Sets the GPIO action for the given channel.
		///  
		///  The action can be a normal stop, a full brake or a callback. Each for a rising
		///  edge or falling edge. The actions are a bitmask they can be used at the same time.
		///  You can for example trigger a full brake and a callback at the same time or for
		///  rising and falling edge.
		///  
		///  The deceleration speed for the normal stop can be configured with
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetGPIOConfiguration"/>.
		/// </summary>
		public void SetGPIOAction(byte channel, long action)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(13, FUNCTION_SET_GPIO_ACTION);
			LEConverter.To((byte)channel, 8, request);
			LEConverter.To((int)action, 9, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the GPIO action for a channel as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetGPIOAction"/>.
		/// </summary>
		public long GetGPIOAction(byte channel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_GET_GPIO_ACTION);
			LEConverter.To((byte)channel, 8, request);

			byte[] response = SendRequest(request, 12);

			return LEConverter.UIntFrom(8, response);
		}

		/// <summary>
		///  Returns the GPIO state for both channels. True if the state is ``high`` and
		///  false if the state is ``low``.
		/// </summary>
		public bool[] GetGPIOState()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_GPIO_STATE);

			byte[] response = SendRequest(request, 9);

			return LEConverter.BoolArrayFrom(8, response, 2);
		}

		/// <summary>
		///  Returns the error count for the communication between Brick and Bricklet.
		///  
		///  The errors are divided into
		///  
		///  * ACK checksum errors,
		///  * message checksum errors,
		///  * framing errors and
		///  * overflow errors.
		///  
		///  The errors counts are for errors that occur on the Bricklet side. All
		///  Bricks have a similar function that returns the errors on the Brick side.
		/// </summary>
		public void GetSPITFPErrorCount(out long errorCountAckChecksum, out long errorCountMessageChecksum, out long errorCountFrame, out long errorCountOverflow)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_SPITFP_ERROR_COUNT);

			byte[] response = SendRequest(request, 24);

			errorCountAckChecksum = LEConverter.UIntFrom(8, response);
			errorCountMessageChecksum = LEConverter.UIntFrom(12, response);
			errorCountFrame = LEConverter.UIntFrom(16, response);
			errorCountOverflow = LEConverter.UIntFrom(20, response);
		}

		/// <summary>
		///  Sets the bootloader mode and returns the status after the requested
		///  mode change was instigated.
		///  
		///  You can change from bootloader mode to firmware mode and vice versa. A change
		///  from bootloader mode to firmware mode will only take place if the entry function,
		///  device identifier and CRC are present and correct.
		///  
		///  This function is used by Brick Viewer during flashing. It should not be
		///  necessary to call it in a normal user program.
		/// </summary>
		public byte SetBootloaderMode(byte mode)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_SET_BOOTLOADER_MODE);
			LEConverter.To((byte)mode, 8, request);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Returns the current bootloader mode, see <see cref="Tinkerforge.BrickletSilentStepperV2.SetBootloaderMode"/>.
		/// </summary>
		public byte GetBootloaderMode()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_BOOTLOADER_MODE);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Sets the firmware pointer for <see cref="Tinkerforge.BrickletSilentStepperV2.WriteFirmware"/>. The pointer has
		///  to be increased by chunks of size 64. The data is written to flash
		///  every 4 chunks (which equals to one page of size 256).
		///  
		///  This function is used by Brick Viewer during flashing. It should not be
		///  necessary to call it in a normal user program.
		/// </summary>
		public void SetWriteFirmwarePointer(long pointer)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_WRITE_FIRMWARE_POINTER);
			LEConverter.To((int)pointer, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Writes 64 Bytes of firmware at the position as written by
		///  <see cref="Tinkerforge.BrickletSilentStepperV2.SetWriteFirmwarePointer"/> before. The firmware is written
		///  to flash every 4 chunks.
		///  
		///  You can only write firmware in bootloader mode.
		///  
		///  This function is used by Brick Viewer during flashing. It should not be
		///  necessary to call it in a normal user program.
		/// </summary>
		public byte WriteFirmware(byte[] data)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(72, FUNCTION_WRITE_FIRMWARE);
			LEConverter.To((byte[])data, 8, 64, request);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Sets the status LED configuration. By default the LED shows
		///  communication traffic between Brick and Bricklet, it flickers once
		///  for every 10 received data packets.
		///  
		///  You can also turn the LED permanently on/off or show a heartbeat.
		///  
		///  If the Bricklet is in bootloader mode, the LED is will show heartbeat by default.
		/// </summary>
		public void SetStatusLEDConfig(byte config)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_SET_STATUS_LED_CONFIG);
			LEConverter.To((byte)config, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletSilentStepperV2.SetStatusLEDConfig"/>
		/// </summary>
		public byte GetStatusLEDConfig()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_STATUS_LED_CONFIG);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Returns the temperature as measured inside the microcontroller. The
		///  value returned is not the ambient temperature!
		///  
		///  The temperature is only proportional to the real temperature and it has bad
		///  accuracy. Practically it is only useful as an indicator for
		///  temperature changes.
		/// </summary>
		public short GetChipTemperature()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_CHIP_TEMPERATURE);

			byte[] response = SendRequest(request, 10);

			return LEConverter.ShortFrom(8, response);
		}

		/// <summary>
		///  Calling this function will reset the Bricklet. All configurations
		///  will be lost.
		///  
		///  After a reset you have to create new device objects,
		///  calling functions on the existing ones will result in
		///  undefined behavior!
		/// </summary>
		public void Reset()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_RESET);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Writes a new UID into flash. If you want to set a new UID
		///  you have to decode the Base58 encoded UID string into an
		///  integer first.
		///  
		///  We recommend that you use Brick Viewer to change the UID.
		/// </summary>
		public void WriteUID(long uid)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_WRITE_UID);
			LEConverter.To((int)uid, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the current UID as an integer. Encode as
		///  Base58 to get the usual string version.
		/// </summary>
		public long ReadUID()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_READ_UID);

			byte[] response = SendRequest(request, 12);

			return LEConverter.UIntFrom(8, response);
		}

		/// <summary>
		///  Returns the UID, the UID where the Bricklet is connected to,
		///  the position, the hardware and firmware version as well as the
		///  device identifier.
		///  
		///  The position can be 'a', 'b', 'c', 'd', 'e', 'f', 'g' or 'h' (Bricklet Port).
		///  A Bricklet connected to an :ref:`Isolator Bricklet &lt;isolator_bricklet&gt;` is always at
		///  position 'z'.
		///  
		///  The device identifier numbers can be found :ref:`here &lt;device_identifier&gt;`.
		///  |device_identifier_constant|
		/// </summary>
		public override void GetIdentity(out string uid, out string connectedUid, out char position, out byte[] hardwareVersion, out byte[] firmwareVersion, out int deviceIdentifier)
		{
			byte[] request = CreateRequestPacket(8, FUNCTION_GET_IDENTITY);

			byte[] response = SendRequest(request, 33);

			uid = LEConverter.StringFrom(8, response, 8);
			connectedUid = LEConverter.StringFrom(16, response, 8);
			position = LEConverter.CharFrom(24, response);
			hardwareVersion = LEConverter.ByteArrayFrom(25, response, 3);
			firmwareVersion = LEConverter.ByteArrayFrom(28, response, 3);
			deviceIdentifier = LEConverter.UShortFrom(31, response);
		}

		/// <summary>
		/// </summary>
		protected void OnUnderVoltageCallback(byte[] response)
		{
			if (response.Length != 10)
			{
				return; // silently ignoring callback with wrong length
			}

			int voltage = LEConverter.UShortFrom(8, response);
			var handler = UnderVoltageCallback;

			if (handler != null)
			{
				handler(this, voltage);
			}
		}

		/// <summary>
		/// </summary>
		protected void OnPositionReachedCallback(byte[] response)
		{
			if (response.Length != 12)
			{
				return; // silently ignoring callback with wrong length
			}

			int position = LEConverter.IntFrom(8, response);
			var handler = PositionReachedCallback;

			if (handler != null)
			{
				handler(this, position);
			}
		}

		/// <summary>
		/// </summary>
		protected void OnAllDataCallback(byte[] response)
		{
			if (response.Length != 22)
			{
				return; // silently ignoring callback with wrong length
			}

			int currentVelocity = LEConverter.UShortFrom(8, response);
			int currentPosition = LEConverter.IntFrom(10, response);
			int remainingSteps = LEConverter.IntFrom(14, response);
			int inputVoltage = LEConverter.UShortFrom(18, response);
			int currentConsumption = LEConverter.UShortFrom(20, response);
			var handler = AllDataCallback;

			if (handler != null)
			{
				handler(this, currentVelocity, currentPosition, remainingSteps, inputVoltage, currentConsumption);
			}
		}

		/// <summary>
		/// </summary>
		protected void OnNewStateCallback(byte[] response)
		{
			if (response.Length != 10)
			{
				return; // silently ignoring callback with wrong length
			}

			byte stateNew = LEConverter.ByteFrom(8, response);
			byte statePrevious = LEConverter.ByteFrom(9, response);
			var handler = NewStateCallback;

			if (handler != null)
			{
				handler(this, stateNew, statePrevious);
			}
		}

		/// <summary>
		/// </summary>
		protected void OnGPIOStateCallback(byte[] response)
		{
			if (response.Length != 9)
			{
				return; // silently ignoring callback with wrong length
			}

			bool[] gpioState = new bool[2];
			byte[] gpioStateBits = new byte[1];
			gpioStateBits = LEConverter.ByteArrayFrom(8, response, 1);
			for (int i = 0; i < 2; i++) {
				gpioState[i] = (gpioStateBits[i / 8] & (1 << (i % 8))) != 0;
			}
			var handler = GPIOStateCallback;

			if (handler != null)
			{
				handler(this, gpioState);
			}
		}
	}
}
