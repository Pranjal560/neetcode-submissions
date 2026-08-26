public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                char currentValue = board[r][c];

                if(currentValue == '.')
                {
                    continue;
                }

                int boxIndex = (r/3)*3 + (c/3);

                if(rows[r].Contains(currentValue) || columns[c].Contains(currentValue) || 
                   boxes[boxIndex].Contains(currentValue))
                {
                    return false;
                }

                rows[r].Add(currentValue);
                columns[c].Add(currentValue);
                boxes[boxIndex].Add(currentValue);   
            }    
        }

        return true;
    }
}
