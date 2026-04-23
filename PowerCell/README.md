```mermaid
classDiagram
class Cell {
+name: string
+charge: float
+level: int

+Consume(float valor) void
+restore() void
-ToString() string
}
```