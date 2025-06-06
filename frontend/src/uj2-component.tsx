import React from "react";

interface Props {
   name: string;
}

const Uj2Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default Uj2Component;