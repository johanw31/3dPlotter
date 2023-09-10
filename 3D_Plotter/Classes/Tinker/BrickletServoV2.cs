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
	///  Drives up to 10 RC Servos
	/// </summary>
	public class BrickletServoV2 : Device
	{
		/// <summary>
		///  Used to identify this device type in
		///  <see cref="Tinkerforge.IPConnection.EnumerateCallback"/>.
		/// </summary>
		public static int DEVICE_IDENTIFIER = 2157;

		/// <summary>
		///  The display name of this device.
		/// </summary>
		public static string DEVICE_DISPLAY_NAME = "Servo Bricklet 2.0";

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_STATUS = 1;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_ENABLE = 2;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_ENABLED = 3;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_POSITION = 4;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_POSITION = 5;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CURRENT_POSITION = 6;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CURRENT_VELOCITY = 7;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_MOTION_CONFIGURATION = 8;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_MOTION_CONFIGURATION = 9;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_PULSE_WIDTH = 10;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_PULSE_WIDTH = 11;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_DEGREE = 12;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_DEGREE = 13;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_PERIOD = 14;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_PERIOD = 15;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_SERVO_CURRENT = 16;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_SERVO_CURRENT_CONFIGURATION = 17;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_SERVO_CURRENT_CONFIGURATION = 18;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_INPUT_VOLTAGE_CONFIGURATION = 19;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_INPUT_VOLTAGE_CONFIGURATION = 20;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_OVERALL_CURRENT = 21;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_INPUT_VOLTAGE = 22;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_CURRENT_CALIBRATION = 23;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_CURRENT_CALIBRATION = 24;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_SET_POSITION_REACHED_CALLBACK_CONFIGURATION = 25;

		/// <summary>
		///  Function ID to be used with
		///  <see cref="Tinkerforge.Device.GetResponseExpected"/> and
		///  <see cref="Tinkerforge.Device.SetResponseExpected"/>.
		/// </summary>
		public const byte FUNCTION_GET_POSITION_REACHED_CALLBACK_CONFIGURATION = 26;

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

		private const int CALLBACK_POSITION_REACHED = 27;


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
		///  This callback is triggered when a position set by <see cref="Tinkerforge.BrickletServoV2.SetPosition"/>
		///  is reached. If the new position matches the current position then the
		///  callback is not triggered, because the servo didn't move.
		///  The parameters are the servo and the position that is reached.
		///  
		///  You can enable this callback with <see cref="Tinkerforge.BrickletServoV2.SetPositionReachedCallbackConfiguration"/>.
		///  
		///  <note>
		///   Since we can't get any feedback from the servo, this only works if the
		///   velocity (see <see cref="Tinkerforge.BrickletServoV2.SetMotionConfiguration"/>) is set smaller or equal to the
		///   maximum velocity of the servo. Otherwise the servo will lag behind the
		///   control value and the callback will be triggered too early.
		///  </note>
		/// </summary>
		public event PositionReachedEventHandler PositionReachedCallback;
		/// <summary>
		/// </summary>
		public delegate void PositionReachedEventHandler(BrickletServoV2 sender, int servoChannel, short position);

		/// <summary>
		///  Creates an object with the unique device ID <c>uid</c> and adds  it to
		///  the IPConnection <c>ipcon</c>.
		/// </summary>
		public BrickletServoV2(string uid, IPConnection ipcon) : base(uid, ipcon, DEVICE_IDENTIFIER, DEVICE_DISPLAY_NAME)
		{
			apiVersion[0] = 2;
			apiVersion[1] = 0;
			apiVersion[2] = 0;

			callbackWrappers[CALLBACK_POSITION_REACHED] = new CallbackWrapper(OnPositionReachedCallback);


			responseExpected[FUNCTION_GET_STATUS] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_ENABLE] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_ENABLED] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_POSITION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_POSITION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_CURRENT_POSITION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_CURRENT_VELOCITY] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_MOTION_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_MOTION_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_PULSE_WIDTH] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_PULSE_WIDTH] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_DEGREE] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_DEGREE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_PERIOD] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_PERIOD] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_SERVO_CURRENT] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_SERVO_CURRENT_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_SERVO_CURRENT_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_INPUT_VOLTAGE_CONFIGURATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_INPUT_VOLTAGE_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_OVERALL_CURRENT] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_GET_INPUT_VOLTAGE] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_CURRENT_CALIBRATION] = ResponseExpectedFlag.FALSE;
			responseExpected[FUNCTION_GET_CURRENT_CALIBRATION] = ResponseExpectedFlag.ALWAYS_TRUE;
			responseExpected[FUNCTION_SET_POSITION_REACHED_CALLBACK_CONFIGURATION] = ResponseExpectedFlag.TRUE;
			responseExpected[FUNCTION_GET_POSITION_REACHED_CALLBACK_CONFIGURATION] = ResponseExpectedFlag.ALWAYS_TRUE;
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
		///  Returns the status information of the Servo Bricklet 2.0.
		///  
		///  The status includes
		///  
		///  * for each channel if it is enabled or disabled,
		///  * for each channel the current position,
		///  * for each channel the current velocity,
		///  * for each channel the current usage and
		///  * the input voltage.
		///  
		///  Please note that the position and the velocity is a snapshot of the
		///  current position and velocity of the servo in motion.
		/// </summary>
		public void GetStatus(out bool[] enabled, out short[] currentPosition, out short[] currentVelocity, out int[] current, out int inputVoltage)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_STATUS);

			byte[] response = SendRequest(request, 72);

			byte[] enabledBits = new byte[2];
			enabled = new bool[10];
			enabledBits = LEConverter.ByteArrayFrom(8, response, 2);
			for (int i = 0; i < 10; i++) {
				enabled[i] = (enabledBits[i / 8] & (1 << (i % 8))) != 0;
			}
			currentPosition = LEConverter.ShortArrayFrom(10, response, 10);
			currentVelocity = LEConverter.ShortArrayFrom(30, response, 10);
			current = LEConverter.UShortArrayFrom(50, response, 10);
			inputVoltage = LEConverter.UShortFrom(70, response);
		}

		/// <summary>
		///  Enables a servo channel (0 to 9). If a servo is enabled, the configured position,
		///  velocity, acceleration, etc. are applied immediately.
		/// </summary>
		public void SetEnable(int servoChannel, bool enable)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(11, FUNCTION_SET_ENABLE);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((bool)enable, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns *true* if the specified servo channel is enabled, *false* otherwise.
		/// </summary>
		public bool GetEnabled(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_ENABLED);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 9);

			return LEConverter.BoolFrom(8, response);
		}

		/// <summary>
		///  Sets the position in °/100 for the specified servo channel.
		///  
		///  The default range of the position is -9000 to 9000, but it can be specified
		///  according to your servo with <see cref="Tinkerforge.BrickletServoV2.SetDegree"/>.
		///  
		///  If you want to control a linear servo or RC brushless motor controller or
		///  similar with the Servo Brick, you can also define lengths or speeds with
		///  <see cref="Tinkerforge.BrickletServoV2.SetDegree"/>.
		/// </summary>
		public void SetPosition(int servoChannel, short position)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(12, FUNCTION_SET_POSITION);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((short)position, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the position of the specified servo channel as set by <see cref="Tinkerforge.BrickletServoV2.SetPosition"/>.
		/// </summary>
		public short GetPosition(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_POSITION);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 10);

			return LEConverter.ShortFrom(8, response);
		}

		/// <summary>
		///  Returns the *current* position of the specified servo channel. This may not be the
		///  value of <see cref="Tinkerforge.BrickletServoV2.SetPosition"/> if the servo is currently approaching a
		///  position goal.
		/// </summary>
		public short GetCurrentPosition(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_CURRENT_POSITION);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 10);

			return LEConverter.ShortFrom(8, response);
		}

		/// <summary>
		///  Returns the *current* velocity of the specified servo channel. This may not be the
		///  velocity specified by <see cref="Tinkerforge.BrickletServoV2.SetMotionConfiguration"/>. if the servo is
		///  currently approaching a velocity goal.
		/// </summary>
		public int GetCurrentVelocity(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_CURRENT_VELOCITY);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets the maximum velocity of the specified servo channel in °/100s as well as
		///  the acceleration and deceleration in °/100s²
		///  
		///  With a velocity of 0 °/100s the position will be set immediately (no velocity).
		///  
		///  With an acc-/deceleration of 0 °/100s² the velocity will be set immediately
		///  (no acc-/deceleration).
		/// </summary>
		public void SetMotionConfiguration(int servoChannel, long velocity, long acceleration, long deceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(22, FUNCTION_SET_MOTION_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((int)velocity, 10, request);
			LEConverter.To((int)acceleration, 14, request);
			LEConverter.To((int)deceleration, 18, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the motion configuration as set by <see cref="Tinkerforge.BrickletServoV2.SetMotionConfiguration"/>.
		/// </summary>
		public void GetMotionConfiguration(int servoChannel, out long velocity, out long acceleration, out long deceleration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_MOTION_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 20);

			velocity = LEConverter.UIntFrom(8, response);
			acceleration = LEConverter.UIntFrom(12, response);
			deceleration = LEConverter.UIntFrom(16, response);
		}

		/// <summary>
		///  Sets the minimum and maximum pulse width of the specified servo channel in µs.
		///  
		///  Usually, servos are controlled with a
		///  `PWM &lt;https://en.wikipedia.org/wiki/Pulse-width_modulation&gt;`__, whereby the
		///  length of the pulse controls the position of the servo. Every servo has
		///  different minimum and maximum pulse widths, these can be specified with
		///  this function.
		///  
		///  If you have a datasheet for your servo that specifies the minimum and
		///  maximum pulse width, you should set the values accordingly. If your servo
		///  comes without any datasheet you have to find the values via trial and error.
		///  
		///  Both values have a range from 1 to 65535 (unsigned 16-bit integer). The
		///  minimum must be smaller than the maximum.
		///  
		///  The default values are 1000µs (1ms) and 2000µs (2ms) for minimum and
		///  maximum pulse width.
		/// </summary>
		public void SetPulseWidth(int servoChannel, long min, long max)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(18, FUNCTION_SET_PULSE_WIDTH);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((int)min, 10, request);
			LEConverter.To((int)max, 14, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the minimum and maximum pulse width for the specified servo channel as set by
		///  <see cref="Tinkerforge.BrickletServoV2.SetPulseWidth"/>.
		/// </summary>
		public void GetPulseWidth(int servoChannel, out long min, out long max)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_PULSE_WIDTH);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 16);

			min = LEConverter.UIntFrom(8, response);
			max = LEConverter.UIntFrom(12, response);
		}

		/// <summary>
		///  Sets the minimum and maximum degree for the specified servo channel (by default
		///  given as °/100).
		///  
		///  This only specifies the abstract values between which the minimum and maximum
		///  pulse width is scaled. For example: If you specify a pulse width of 1000µs
		///  to 2000µs and a degree range of -90° to 90°, a call of <see cref="Tinkerforge.BrickletServoV2.SetPosition"/>
		///  with 0 will result in a pulse width of 1500µs
		///  (-90° = 1000µs, 90° = 2000µs, etc.).
		///  
		///  Possible usage:
		///  
		///  * The datasheet of your servo specifies a range of 200° with the middle position
		///    at 110°. In this case you can set the minimum to -9000 and the maximum to 11000.
		///  * You measure a range of 220° on your servo and you don't have or need a middle
		///    position. In this case you can set the minimum to 0 and the maximum to 22000.
		///  * You have a linear servo with a drive length of 20cm, In this case you could
		///    set the minimum to 0 and the maximum to 20000. Now you can set the Position
		///    with <see cref="Tinkerforge.BrickletServoV2.SetPosition"/> with a resolution of cm/100. Also the velocity will
		///    have a resolution of cm/100s and the acceleration will have a resolution of
		///    cm/100s².
		///  * You don't care about units and just want the highest possible resolution. In
		///    this case you should set the minimum to -32767 and the maximum to 32767.
		///  * You have a brushless motor with a maximum speed of 10000 rpm and want to
		///    control it with a RC brushless motor controller. In this case you can set the
		///    minimum to 0 and the maximum to 10000. <see cref="Tinkerforge.BrickletServoV2.SetPosition"/> now controls the rpm.
		///  
		///  Both values have a possible range from -32767 to 32767
		///  (signed 16-bit integer). The minimum must be smaller than the maximum.
		///  
		///  The default values are -9000 and 9000 for the minimum and maximum degree.
		/// </summary>
		public void SetDegree(int servoChannel, short min, short max)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(14, FUNCTION_SET_DEGREE);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((short)min, 10, request);
			LEConverter.To((short)max, 12, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the minimum and maximum degree for the specified servo channel as set by
		///  <see cref="Tinkerforge.BrickletServoV2.SetDegree"/>.
		/// </summary>
		public void GetDegree(int servoChannel, out short min, out short max)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_DEGREE);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 12);

			min = LEConverter.ShortFrom(8, response);
			max = LEConverter.ShortFrom(10, response);
		}

		/// <summary>
		///  Sets the period of the specified servo channel in µs.
		///  
		///  Usually, servos are controlled with a
		///  `PWM &lt;https://en.wikipedia.org/wiki/Pulse-width_modulation&gt;`__. Different
		///  servos expect PWMs with different periods. Most servos run well with a
		///  period of about 20ms.
		///  
		///  If your servo comes with a datasheet that specifies a period, you should
		///  set it accordingly. If you don't have a datasheet and you have no idea
		///  what the correct period is, the default value (19.5ms) will most likely
		///  work fine.
		///  
		///  The minimum possible period is 1µs and the maximum is 1000000µs.
		///  
		///  The default value is 19.5ms (19500µs).
		/// </summary>
		public void SetPeriod(int servoChannel, long period)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(14, FUNCTION_SET_PERIOD);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((int)period, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the period for the specified servo channel as set by <see cref="Tinkerforge.BrickletServoV2.SetPeriod"/>.
		/// </summary>
		public long GetPeriod(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_PERIOD);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 12);

			return LEConverter.UIntFrom(8, response);
		}

		/// <summary>
		///  Returns the current consumption of the specified servo channel in mA.
		/// </summary>
		public int GetServoCurrent(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_SERVO_CURRENT);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets the averaging duration of the current measurement for the specified servo channel in ms.
		/// </summary>
		public void SetServoCurrentConfiguration(int servoChannel, byte averagingDuration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(11, FUNCTION_SET_SERVO_CURRENT_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((byte)averagingDuration, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the servo current configuration for the specified servo channel as set
		///  by <see cref="Tinkerforge.BrickletServoV2.SetServoCurrentConfiguration"/>.
		/// </summary>
		public byte GetServoCurrentConfiguration(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_SERVO_CURRENT_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Sets the averaging duration of the input voltage measurement for the specified servo channel in ms.
		/// </summary>
		public void SetInputVoltageConfiguration(byte averagingDuration)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(9, FUNCTION_SET_INPUT_VOLTAGE_CONFIGURATION);
			LEConverter.To((byte)averagingDuration, 8, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the input voltage configuration as set by <see cref="Tinkerforge.BrickletServoV2.SetInputVoltageConfiguration"/>.
		/// </summary>
		public byte GetInputVoltageConfiguration()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_INPUT_VOLTAGE_CONFIGURATION);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Returns the current consumption of all servos together in mA.
		/// </summary>
		public int GetOverallCurrent()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_OVERALL_CURRENT);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Returns the input voltage in mV. The input voltage is
		///  given via the black power input connector on the Servo Brick.
		/// </summary>
		public int GetInputVoltage()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_INPUT_VOLTAGE);

			byte[] response = SendRequest(request, 10);

			return LEConverter.UShortFrom(8, response);
		}

		/// <summary>
		///  Sets an offset value (in mA) for each channel.
		///  
		///  Note: On delivery the Servo Bricklet 2.0 is already calibrated.
		/// </summary>
		public void SetCurrentCalibration(short[] offset)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(28, FUNCTION_SET_CURRENT_CALIBRATION);
			LEConverter.To((short[])offset, 8, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the current calibration as set by <see cref="Tinkerforge.BrickletServoV2.SetCurrentCalibration"/>.
		/// </summary>
		public short[] GetCurrentCalibration()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_CURRENT_CALIBRATION);

			byte[] response = SendRequest(request, 28);

			return LEConverter.ShortArrayFrom(8, response, 10);
		}

		/// <summary>
		///  Enable/Disable <see cref="Tinkerforge.BrickletServoV2.PositionReachedCallback"/> callback.
		/// </summary>
		public void SetPositionReachedCallbackConfiguration(int servoChannel, bool enabled)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(11, FUNCTION_SET_POSITION_REACHED_CALLBACK_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);
			LEConverter.To((bool)enabled, 10, request);

			SendRequest(request, 0);

		}

		/// <summary>
		///  Returns the callback configuration as set by
		///  <see cref="Tinkerforge.BrickletServoV2.SetPositionReachedCallbackConfiguration"/>.
		/// </summary>
		public bool GetPositionReachedCallbackConfiguration(int servoChannel)
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(10, FUNCTION_GET_POSITION_REACHED_CALLBACK_CONFIGURATION);
			LEConverter.To((short)servoChannel, 8, request);

			byte[] response = SendRequest(request, 9);

			return LEConverter.BoolFrom(8, response);
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
		///  Returns the current bootloader mode, see <see cref="Tinkerforge.BrickletServoV2.SetBootloaderMode"/>.
		/// </summary>
		public byte GetBootloaderMode()
		{
			CheckValidity();

			byte[] request = CreateRequestPacket(8, FUNCTION_GET_BOOTLOADER_MODE);

			byte[] response = SendRequest(request, 9);

			return LEConverter.ByteFrom(8, response);
		}

		/// <summary>
		///  Sets the firmware pointer for <see cref="Tinkerforge.BrickletServoV2.WriteFirmware"/>. The pointer has
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
		///  <see cref="Tinkerforge.BrickletServoV2.SetWriteFirmwarePointer"/> before. The firmware is written
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
		///  Returns the configuration as set by <see cref="Tinkerforge.BrickletServoV2.SetStatusLEDConfig"/>
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
		protected void OnPositionReachedCallback(byte[] response)
		{
			if (response.Length != 12)
			{
				return; // silently ignoring callback with wrong length
			}

			int servoChannel = LEConverter.UShortFrom(8, response);
			short position = LEConverter.ShortFrom(10, response);
			var handler = PositionReachedCallback;

			if (handler != null)
			{
				handler(this, servoChannel, position);
			}
		}
	}
}
