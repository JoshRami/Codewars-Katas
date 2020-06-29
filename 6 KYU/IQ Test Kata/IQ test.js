function iqTest(numbers) {
  numbers = numbers.split` `.map((element) => +element);

  // if the conditional return 1 it means, the odd number is a even number
  return numbers.filter((number) => number % 2 === 0).length === 1
    ? numbers.indexOf(numbers.find((number) => number % 2 === 0)) + 1
    : numbers.indexOf(numbers.find((number) => number % 2 === 1)) + 1;
}
