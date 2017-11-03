public class InsertionSort {
  public static void insertionSort(int[] arr) {
    int size = arr.length;
    for(int i = 1; i < size; i++) {
      int currentElement = arr[i];
      int j = i - 1;
      while((j >= 0) && (arr[j] > currentElement)) {
        arr[j+1] = arr[j];
        j--;
      }
      arr[j+1] = currentElement;
    }
  }
  
  public static void main(String[] args) {
    int[] array = {3,5,2,1,9,8,6,7,4};
    insertionSort(array);
    for (int i : array) {
      System.out.println(i);
    }
  }
}
