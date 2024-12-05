namespace practice1
{
    internal class Program
    {
        public static int CountBits(int num)
        {
            string binaryValue = Convert.ToString(num, 2);
            int onesCount = 0;

            foreach (char bit in binaryValue)
                if (bit == '1')
                    onesCount++;

            return onesCount;
        }

        public static int FindPersistence(int num)
        {
            if (num < 10)
                return 0;

            int count = 0;

            while (num >= 10)
            {
                int product = 1;

                while (num > 0)
                {
                    product *= num % 10;
                    num /= 10;
                }

                num = product;
                count++;
            }

            return count;
        }

        public static int FindDigitalRoot(int num)
        {
            if (num < 10)
                return num;

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10; 
            }

            return FindDigitalRoot(sum);
        }

        static void Main(string[] args)
        {
            int[] nums = [4, 10, 1, 32];
            int[] nums1 = [39, 9, 999];
            int[] nums2 = [16, 942];

            Console.WriteLine($"{nums[0]} = {Convert.ToString(nums[0], 2)} => {CountBits(nums[0])}");
            Console.WriteLine($"{nums[1]} = {Convert.ToString(nums[1], 2)} => {CountBits(nums[1])}");
            Console.WriteLine($"{nums[2]} = {Convert.ToString(nums[2], 2)} => {CountBits(nums[2])}");
            Console.WriteLine($"{nums[3]} = {Convert.ToString(nums[3], 2)} => {CountBits(nums[3])}\n");

            Console.WriteLine($"{nums1[0]} => {FindPersistence(nums1[0])}");
            Console.WriteLine($"{nums1[1]} => {FindPersistence(nums1[1])}");
            Console.WriteLine($"{nums1[2]} => {FindPersistence(nums1[2])}\n");

            Console.WriteLine($"{nums2[0]} => {FindDigitalRoot(nums2[0])}");
            Console.WriteLine($"{nums2[1]} => {FindDigitalRoot(nums2[1])}");
        }
    }
}
