// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBool4x4
    {
        [Test]
        public void bool4x4_operator_equal_wide_wide()
        {
            bool4x4 a0 = bool4x4(true, false, true, false, false, true, false, false, true, false, true, false, true, true, false, true);
            bool4x4 b0 = bool4x4(true, false, false, false, true, false, false, true, false, false, false, false, true, false, false, false);
            bool4x4 r0 = bool4x4(true, true, false, true, false, false, true, false, false, true, false, true, true, false, true, false);
            TestUtils.AreEqual(a0 == b0, r0);

            bool4x4 a1 = bool4x4(true, false, false, true, true, true, false, true, true, true, false, true, true, true, false, true);
            bool4x4 b1 = bool4x4(true, false, false, true, false, true, false, true, true, true, true, true, true, false, false, false);
            bool4x4 r1 = bool4x4(true, true, true, true, false, true, true, true, true, true, false, true, true, false, true, false);
            TestUtils.AreEqual(a1 == b1, r1);

            bool4x4 a2 = bool4x4(false, true, false, true, false, true, true, false, true, false, false, false, false, true, true, false);
            bool4x4 b2 = bool4x4(false, true, false, false, true, true, false, true, false, false, false, true, true, true, true, false);
            bool4x4 r2 = bool4x4(true, true, true, false, false, true, false, false, false, true, true, false, false, true, true, true);
            TestUtils.AreEqual(a2 == b2, r2);

            bool4x4 a3 = bool4x4(false, true, false, false, false, true, false, true, false, false, false, true, false, false, false, false);
            bool4x4 b3 = bool4x4(false, true, false, true, true, false, false, false, false, true, true, false, false, false, true, false);
            bool4x4 r3 = bool4x4(true, true, true, false, false, false, true, false, true, false, false, false, true, true, false, true);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool4x4_operator_equal_wide_scalar()
        {
            bool4x4 a0 = bool4x4(false, true, false, false, false, false, true, false, false, false, true, true, false, true, false, true);
            bool b0 = (true);
            bool4x4 r0 = bool4x4(false, true, false, false, false, false, true, false, false, false, true, true, false, true, false, true);
            TestUtils.AreEqual(a0 == b0, r0);

            bool4x4 a1 = bool4x4(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true);
            bool b1 = (false);
            bool4x4 r1 = bool4x4(true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 == b1, r1);

            bool4x4 a2 = bool4x4(true, false, false, false, true, true, false, true, true, false, false, true, false, true, true, false);
            bool b2 = (false);
            bool4x4 r2 = bool4x4(false, true, true, true, false, false, true, false, false, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a2 == b2, r2);

            bool4x4 a3 = bool4x4(false, false, true, false, true, true, true, false, true, false, true, false, false, false, false, false);
            bool b3 = (true);
            bool4x4 r3 = bool4x4(false, false, true, false, true, true, true, false, true, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool4x4_operator_equal_scalar_wide()
        {
            bool a0 = (false);
            bool4x4 b0 = bool4x4(true, false, true, false, false, true, false, false, true, false, true, true, false, true, false, true);
            bool4x4 r0 = bool4x4(false, true, false, true, true, false, true, true, false, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a0 == b0, r0);

            bool a1 = (true);
            bool4x4 b1 = bool4x4(true, false, false, true, false, true, true, false, true, true, true, true, true, true, false, true);
            bool4x4 r1 = bool4x4(true, false, false, true, false, true, true, false, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 == b1, r1);

            bool a2 = (true);
            bool4x4 b2 = bool4x4(false, false, false, true, true, true, false, true, true, true, false, false, true, false, true, true);
            bool4x4 r2 = bool4x4(false, false, false, true, true, true, false, true, true, true, false, false, true, false, true, true);
            TestUtils.AreEqual(a2 == b2, r2);

            bool a3 = (false);
            bool4x4 b3 = bool4x4(false, false, false, true, true, true, true, false, false, true, false, true, false, false, false, false);
            bool4x4 r3 = bool4x4(true, true, true, false, false, false, false, true, true, false, true, false, true, true, true, true);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool4x4_operator_not_equal_wide_wide()
        {
            bool4x4 a0 = bool4x4(true, true, true, false, false, true, false, false, false, false, true, true, true, true, true, true);
            bool4x4 b0 = bool4x4(true, false, false, false, true, false, false, false, false, true, true, true, false, false, true, true);
            bool4x4 r0 = bool4x4(false, true, true, false, true, true, false, false, false, true, false, false, true, true, false, false);
            TestUtils.AreEqual(a0 != b0, r0);

            bool4x4 a1 = bool4x4(true, true, false, true, false, true, true, true, true, false, false, true, false, true, true, true);
            bool4x4 b1 = bool4x4(true, false, true, true, false, false, true, false, false, false, true, false, true, false, true, false);
            bool4x4 r1 = bool4x4(false, true, true, false, false, true, false, true, true, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 != b1, r1);

            bool4x4 a2 = bool4x4(true, true, false, true, true, true, true, false, true, true, true, false, true, false, false, false);
            bool4x4 b2 = bool4x4(false, false, false, false, false, true, false, true, false, true, false, false, false, true, false, false);
            bool4x4 r2 = bool4x4(true, true, false, true, true, false, true, true, true, false, true, false, true, true, false, false);
            TestUtils.AreEqual(a2 != b2, r2);

            bool4x4 a3 = bool4x4(true, false, false, true, false, true, true, true, true, true, false, false, true, false, false, false);
            bool4x4 b3 = bool4x4(true, true, true, false, true, false, false, true, false, false, false, true, true, false, false, false);
            bool4x4 r3 = bool4x4(false, true, true, true, true, true, true, false, true, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool4x4_operator_not_equal_wide_scalar()
        {
            bool4x4 a0 = bool4x4(false, true, false, true, true, false, false, false, false, false, false, false, false, true, false, false);
            bool b0 = (false);
            bool4x4 r0 = bool4x4(false, true, false, true, true, false, false, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a0 != b0, r0);

            bool4x4 a1 = bool4x4(false, true, true, false, true, true, true, true, true, true, false, true, true, true, false, false);
            bool b1 = (false);
            bool4x4 r1 = bool4x4(false, true, true, false, true, true, true, true, true, true, false, true, true, true, false, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool4x4 a2 = bool4x4(true, true, false, true, false, false, false, true, true, true, false, false, true, false, true, false);
            bool b2 = (false);
            bool4x4 r2 = bool4x4(true, true, false, true, false, false, false, true, true, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a2 != b2, r2);

            bool4x4 a3 = bool4x4(true, true, false, false, true, true, false, false, false, false, false, true, false, false, false, true);
            bool b3 = (true);
            bool4x4 r3 = bool4x4(false, false, true, true, false, false, true, true, true, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool4x4_operator_not_equal_scalar_wide()
        {
            bool a0 = (true);
            bool4x4 b0 = bool4x4(false, false, true, false, false, false, true, true, true, false, false, false, false, false, true, false);
            bool4x4 r0 = bool4x4(true, true, false, true, true, true, false, false, false, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool a1 = (false);
            bool4x4 b1 = bool4x4(true, false, false, false, true, true, false, false, true, false, false, true, true, false, true, false);
            bool4x4 r1 = bool4x4(true, false, false, false, true, true, false, false, true, false, false, true, true, false, true, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool a2 = (false);
            bool4x4 b2 = bool4x4(true, true, true, true, true, true, true, true, false, false, true, true, false, false, false, true);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, false, false, true, true, false, false, false, true);
            TestUtils.AreEqual(a2 != b2, r2);

            bool a3 = (true);
            bool4x4 b3 = bool4x4(false, true, false, false, true, true, false, true, false, true, true, false, true, true, true, true);
            bool4x4 r3 = bool4x4(true, false, true, true, false, false, true, false, true, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_and_wide_wide()
        {
            bool4x4 a0 = bool4x4(false, false, true, true, false, false, true, true, true, false, true, true, true, true, false, false);
            bool4x4 b0 = bool4x4(false, false, true, false, true, true, false, false, true, true, false, false, false, false, true, false);
            bool4x4 r0 = bool4x4(false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool4x4 a1 = bool4x4(true, true, true, false, true, true, false, true, true, false, true, true, true, false, false, true);
            bool4x4 b1 = bool4x4(true, false, true, true, true, true, true, true, true, true, true, false, false, false, true, false);
            bool4x4 r1 = bool4x4(true, false, true, false, true, true, false, true, true, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 & b1, r1);

            bool4x4 a2 = bool4x4(true, false, false, true, true, false, true, false, false, false, true, false, false, true, false, true);
            bool4x4 b2 = bool4x4(false, true, true, true, false, true, true, false, true, true, false, false, false, true, true, true);
            bool4x4 r2 = bool4x4(false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a2 & b2, r2);

            bool4x4 a3 = bool4x4(false, false, true, true, false, false, false, false, false, true, false, true, false, false, true, true);
            bool4x4 b3 = bool4x4(false, true, false, false, false, true, true, false, false, false, false, false, true, false, false, true);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_and_wide_scalar()
        {
            bool4x4 a0 = bool4x4(true, false, false, true, true, false, false, false, false, false, true, true, true, false, false, true);
            bool b0 = (true);
            bool4x4 r0 = bool4x4(true, false, false, true, true, false, false, false, false, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a0 & b0, r0);

            bool4x4 a1 = bool4x4(true, false, true, false, true, true, true, false, false, false, false, false, true, false, true, false);
            bool b1 = (true);
            bool4x4 r1 = bool4x4(true, false, true, false, true, true, true, false, false, false, false, false, true, false, true, false);
            TestUtils.AreEqual(a1 & b1, r1);

            bool4x4 a2 = bool4x4(false, false, true, false, true, false, true, false, false, true, false, true, false, true, false, true);
            bool b2 = (false);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool4x4 a3 = bool4x4(false, false, true, false, true, false, false, false, false, true, false, false, true, true, true, true);
            bool b3 = (true);
            bool4x4 r3 = bool4x4(false, false, true, false, true, false, false, false, false, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_and_scalar_wide()
        {
            bool a0 = (false);
            bool4x4 b0 = bool4x4(false, false, true, true, true, false, true, false, false, false, true, false, false, false, true, true);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool a1 = (true);
            bool4x4 b1 = bool4x4(true, false, true, true, true, true, true, false, true, false, true, false, false, false, true, true);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, false, true, false, true, false, false, false, true, true);
            TestUtils.AreEqual(a1 & b1, r1);

            bool a2 = (true);
            bool4x4 b2 = bool4x4(true, true, false, true, false, false, true, true, true, false, true, true, true, true, true, false);
            bool4x4 r2 = bool4x4(true, true, false, true, false, false, true, true, true, false, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool a3 = (false);
            bool4x4 b3 = bool4x4(true, true, false, true, true, true, false, true, false, false, true, true, true, false, false, true);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_or_wide_wide()
        {
            bool4x4 a0 = bool4x4(true, true, true, false, true, false, true, true, false, true, true, true, true, true, true, false);
            bool4x4 b0 = bool4x4(false, false, false, false, true, true, true, false, false, true, false, false, true, true, true, true);
            bool4x4 r0 = bool4x4(true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool4x4 a1 = bool4x4(true, true, false, true, true, false, true, false, true, true, false, true, false, false, false, false);
            bool4x4 b1 = bool4x4(true, true, false, true, true, true, false, true, false, true, false, false, true, true, true, true);
            bool4x4 r1 = bool4x4(true, true, false, true, true, true, true, true, true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool4x4 a2 = bool4x4(false, false, true, true, true, false, false, false, false, true, false, false, true, false, true, false);
            bool4x4 b2 = bool4x4(false, false, false, true, false, false, false, true, false, false, true, true, true, true, true, false);
            bool4x4 r2 = bool4x4(false, false, true, true, true, false, false, true, false, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 | b2, r2);

            bool4x4 a3 = bool4x4(false, false, false, true, false, false, false, false, true, false, true, false, true, true, true, false);
            bool4x4 b3 = bool4x4(true, true, false, true, true, false, true, false, true, true, false, true, false, false, false, false);
            bool4x4 r3 = bool4x4(true, true, false, true, true, false, true, false, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_or_wide_scalar()
        {
            bool4x4 a0 = bool4x4(true, true, false, true, true, true, true, false, true, false, false, true, false, false, true, false);
            bool b0 = (true);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool4x4 a1 = bool4x4(true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true);
            bool b1 = (true);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool4x4 a2 = bool4x4(true, false, true, false, false, true, false, true, false, true, true, false, true, true, false, true);
            bool b2 = (true);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool4x4 a3 = bool4x4(false, true, true, true, true, true, false, false, false, true, true, false, false, true, true, false);
            bool b3 = (true);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_or_scalar_wide()
        {
            bool a0 = (true);
            bool4x4 b0 = bool4x4(true, true, false, false, true, true, true, false, false, true, true, false, true, true, false, false);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool a1 = (false);
            bool4x4 b1 = bool4x4(false, true, true, true, true, true, false, true, false, true, true, false, true, true, false, true);
            bool4x4 r1 = bool4x4(false, true, true, true, true, true, false, true, false, true, true, false, true, true, false, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool a2 = (true);
            bool4x4 b2 = bool4x4(false, false, true, true, true, false, false, false, false, false, false, true, true, false, true, true);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool a3 = (true);
            bool4x4 b3 = bool4x4(true, true, false, false, false, true, true, true, true, false, true, false, false, true, true, true);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_xor_wide_wide()
        {
            bool4x4 a0 = bool4x4(true, false, false, true, false, false, false, true, false, false, true, true, false, false, true, false);
            bool4x4 b0 = bool4x4(true, true, false, true, false, true, false, true, false, false, false, true, false, false, true, true);
            bool4x4 r0 = bool4x4(false, true, false, false, false, true, false, false, false, false, true, false, false, false, false, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool4x4 a1 = bool4x4(true, false, false, false, true, false, true, false, true, false, false, false, true, true, true, true);
            bool4x4 b1 = bool4x4(false, false, false, false, false, true, false, false, false, true, false, true, true, false, false, true);
            bool4x4 r1 = bool4x4(true, false, false, false, true, true, true, false, true, true, false, true, false, true, true, false);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool4x4 a2 = bool4x4(true, true, false, false, true, true, true, true, true, true, false, true, false, false, true, true);
            bool4x4 b2 = bool4x4(false, true, true, false, true, false, false, false, false, true, false, true, false, true, true, true);
            bool4x4 r2 = bool4x4(true, false, true, false, false, true, true, true, true, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool4x4 a3 = bool4x4(true, true, false, false, true, true, true, false, true, false, true, false, true, true, true, true);
            bool4x4 b3 = bool4x4(true, false, true, false, false, false, false, true, true, false, false, true, false, true, true, true);
            bool4x4 r3 = bool4x4(false, true, true, false, true, true, true, true, false, false, true, true, true, false, false, false);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_xor_wide_scalar()
        {
            bool4x4 a0 = bool4x4(false, false, true, true, false, false, false, false, false, false, false, true, false, true, true, true);
            bool b0 = (false);
            bool4x4 r0 = bool4x4(false, false, true, true, false, false, false, false, false, false, false, true, false, true, true, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool4x4 a1 = bool4x4(true, true, false, false, true, false, false, false, true, false, true, true, true, true, false, true);
            bool b1 = (false);
            bool4x4 r1 = bool4x4(true, true, false, false, true, false, false, false, true, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool4x4 a2 = bool4x4(false, true, true, false, true, true, false, false, true, false, true, false, false, true, true, false);
            bool b2 = (false);
            bool4x4 r2 = bool4x4(false, true, true, false, true, true, false, false, true, false, true, false, false, true, true, false);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool4x4 a3 = bool4x4(true, true, true, false, true, true, true, true, true, true, true, true, false, true, false, false);
            bool b3 = (true);
            bool4x4 r3 = bool4x4(false, false, false, true, false, false, false, false, false, false, false, false, true, false, true, true);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_xor_scalar_wide()
        {
            bool a0 = (true);
            bool4x4 b0 = bool4x4(true, false, true, true, false, true, true, false, false, true, true, false, false, true, false, true);
            bool4x4 r0 = bool4x4(false, true, false, false, true, false, false, true, true, false, false, true, true, false, true, false);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool a1 = (true);
            bool4x4 b1 = bool4x4(false, true, true, true, false, false, false, true, true, true, false, false, false, true, true, false);
            bool4x4 r1 = bool4x4(true, false, false, false, true, true, true, false, false, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool a2 = (true);
            bool4x4 b2 = bool4x4(false, false, true, true, true, true, false, false, false, true, false, false, false, true, true, false);
            bool4x4 r2 = bool4x4(true, true, false, false, false, false, true, true, true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool a3 = (false);
            bool4x4 b3 = bool4x4(false, true, true, true, true, true, true, true, true, true, false, false, true, false, true, false);
            bool4x4 r3 = bool4x4(false, true, true, true, true, true, true, true, true, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool4x4_operator_bitwise_not()
        {
            bool4x4 a0 = bool4x4(false, false, false, false, true, false, true, true, false, false, false, false, false, false, true, false);
            bool4x4 r0 = bool4x4(true, true, true, true, false, true, false, false, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(!a0, r0);

            bool4x4 a1 = bool4x4(false, false, true, true, false, false, true, false, false, true, true, false, false, false, false, false);
            bool4x4 r1 = bool4x4(true, true, false, false, true, true, false, true, true, false, false, true, true, true, true, true);
            TestUtils.AreEqual(!a1, r1);

            bool4x4 a2 = bool4x4(true, false, false, true, false, true, true, false, true, false, false, false, true, true, false, false);
            bool4x4 r2 = bool4x4(false, true, true, false, true, false, false, true, false, true, true, true, false, false, true, true);
            TestUtils.AreEqual(!a2, r2);

            bool4x4 a3 = bool4x4(false, false, false, true, false, false, true, false, false, true, false, false, true, false, false, true);
            bool4x4 r3 = bool4x4(true, true, true, false, true, true, false, true, true, false, true, true, false, true, true, false);
            TestUtils.AreEqual(!a3, r3);
        }


    }
}
