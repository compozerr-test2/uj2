import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import Uj2Component from '../../uj2-component'

export const Route = createFileRoute('/uj2/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <Uj2Component name="World!" />
    </div>
  )
}
